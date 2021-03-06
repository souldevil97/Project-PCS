CREATE OR REPLACE FUNCTION GENERATEKODEMEMBER(NAMA VARCHAR2)
RETURN VARCHAR2 
IS
    JUMLAH NUMBER;
    KODE VARCHAR2(6);
BEGIN
    IF (LENGTH(NAMA)-LENGTH(REPLACE(NAMA, ' ', '')) = 0) THEN
        SELECT SUBSTR(NAMA,1,2) INTO KODE FROM DUAL;
    ELSE
        SELECT SUBSTR(NAMA,1,1) || SUBSTR(NAMA,INSTR(NAMA,' ')+1,1) INTO KODE FROM DUAL;
    END IF;
    KODE := 'M' || UPPER(KODE);
    SELECT COUNT(*)+1 INTO JUMLAH FROM MEMBER WHERE SUBSTR(ID_MEMBER,1,3) = KODE;
    RETURN KODE || LPAD(JUMLAH,3,'0');
END;
/

CREATE OR REPLACE TRIGGER INSERTMEMBER
BEFORE INSERT ON MEMBER
FOR EACH ROW
DECLARE
    JUMLAH NUMBER;
    KODE VARCHAR2(6);
    EXP DATE;
BEGIN
    SELECT GENERATEKODEMEMBER(:NEW.NAMA_MEMBER) INTO KODE FROM DUAL;
    :NEW.ID_MEMBER := KODE;
    :NEW.NAMA_MEMBER := INITCAP(:NEW.NAMA_MEMBER);
    :NEW.PASSWORD_MEMBER := KODE || '123';
    SELECT ADD_MONTHS(TO_DATE(SYSDATE, 'DD-MM-YYYY'),12)-1 INTO EXP FROM DUAL;
    :NEW.STATUS_AKTIF := '1';
    :NEW.TGL_EXP :=  EXP; 
END;
/ 

CREATE OR REPLACE TRIGGER INSERTABSENSIPENGUNJUNG
BEFORE INSERT ON ABSENSI_PENGUNJUNG
FOR EACH ROW
DECLARE
    JUMLAH NUMBER;
    KODE VARCHAR2(12);
    TGL DATE;
BEGIN
    KODE := 'A' || TO_CHAR(SYSDATE,'YYYYMMDD');
    SELECT COUNT(*)+1 INTO JUMLAH FROM ABSENSI_PENGUNJUNG WHERE SUBSTR(NOMOR_ABSENSI_PENGUNJUNG,1,9) = KODE;
	:NEW.NOMOR_ABSENSI_PENGUNJUNG := 'A' || TO_CHAR(SYSDATE,'YYYYMMDD') || LPAD(JUMLAH,3,'0');
    :NEW.NAMA_PENGUNJUNG := INITCAP(:NEW.NAMA_PENGUNJUNG);
    SELECT TO_DATE(SYSDATE,'DD-MM-YYYY HH24:MI:SS') INTO TGL FROM DUAL;
    :NEW.WAKTU_DATANG_ABSEN :=  TGL; 
END;
/ 

CREATE OR REPLACE FUNCTION GENERATEKODEPEGAWAI(NAMA VARCHAR2)
RETURN VARCHAR2 
IS
    JUMLAH NUMBER;
    KODE VARCHAR2(6);
BEGIN
    IF (LENGTH(NAMA)-LENGTH(REPLACE(NAMA, ' ', '')) = 0) THEN
        SELECT SUBSTR(NAMA,1,2) INTO KODE FROM DUAL;
    ELSE
        SELECT SUBSTR(NAMA,1,1) || SUBSTR(NAMA,INSTR(NAMA,' ')+1,1) INTO KODE FROM DUAL;
    END IF;
    KODE := 'P' || UPPER(KODE);
    SELECT COUNT(*)+1 INTO JUMLAH FROM PEGAWAI WHERE SUBSTR(ID_PEGAWAI,1,3) = KODE;
    RETURN KODE || LPAD(JUMLAH,3,'0');
END;
/

CREATE OR REPLACE TRIGGER INSERTPEGAWAI
BEFORE INSERT ON PEGAWAI
FOR EACH ROW
DECLARE
    JUMLAH NUMBER;
    KODE VARCHAR2(6);
    EXP DATE;
BEGIN
    SELECT GENERATEKODEPEGAWAI(:NEW.NAMA_PEGAWAI) INTO KODE FROM DUAL;
    :NEW.ID_PEGAWAI := KODE;
    :NEW.NAMA_PEGAWAI := INITCAP(:NEW.NAMA_PEGAWAI);
    :NEW.PASSWORD_PEGAWAI := KODE || '123';
    :NEW.STATUS_AKTIF := '1';
END;
/ 

CREATE OR REPLACE FUNCTION GENERATEKODEPENERBIT
RETURN VARCHAR2 
IS
    JUMLAH NUMBER;
BEGIN
    SELECT COUNT(*)+1 INTO JUMLAH FROM PENERBIT;
    RETURN 'PUB' || LPAD(JUMLAH,4,'0');
END;
/

CREATE OR REPLACE TRIGGER INSERTPENERBIT
BEFORE INSERT ON PENERBIT
FOR EACH ROW
DECLARE
    JUMLAH NUMBER;
    KODE VARCHAR2(7);
BEGIN
    SELECT GENERATEKODEPENERBIT INTO KODE FROM DUAL;
    :NEW.ID_PENERBIT := KODE;
    :NEW.NAMA_PENERBIT := INITCAP(:NEW.NAMA_PENERBIT);
END;
/

CREATE OR REPLACE TRIGGER INSERTKATEGORI
BEFORE INSERT ON KATEGORI
FOR EACH ROW
DECLARE
    JUMLAH NUMBER;
BEGIN
    SELECT COUNT(*)+1 INTO JUMLAH FROM KATEGORI;
    :NEW.ID_KATEGORI := 'K' || LPAD(JUMLAH,4,'0');
    :NEW.NAMA_KATEGORI := UPPER(:NEW.NAMA_KATEGORI);
END;
/

CREATE OR REPLACE FUNCTION GENERATEKODEBUKU
RETURN VARCHAR2 
IS
    JUMLAH NUMBER;
BEGIN
    SELECT COUNT(*)+1 INTO JUMLAH FROM BUKU;
    RETURN 'B' || LPAD(JUMLAH,4,'0');
END;
/

CREATE OR REPLACE TRIGGER INSERTBUKU
BEFORE INSERT ON BUKU
FOR EACH ROW
DECLARE
    KODE VARCHAR2(5);
BEGIN
    SELECT GENERATEKODEBUKU INTO KODE FROM DUAL;
    :NEW.ID_BUKU := KODE;
    :NEW.DIBOOKING := '0';
    :NEW.DIPINJAM := '0';
    :NEW.STATUS_BUKU := '1';
END;
/

CREATE OR REPLACE TRIGGER INSERTPENGARANG
BEFORE INSERT ON PENGARANG
FOR EACH ROW
DECLARE
    JUMLAH NUMBER;
BEGIN
    SELECT COUNT(*)+1 INTO JUMLAH FROM PENGARANG;
    :NEW.ID_PENGARANG := 'AU' || LPAD(JUMLAH,4,'0');
END;
/

CREATE OR REPLACE TRIGGER INSERTH_BOOKING
BEFORE INSERT ON H_BOOKING
FOR EACH ROW
DECLARE
    JUMLAH NUMBER;
    KODE VARCHAR2(12);
BEGIN
    KODE := TO_CHAR(SYSDATE,'YYYYMMDD');
    SELECT COUNT(*)+1 INTO JUMLAH FROM H_BOOKING WHERE SUBSTR(ID_BOOKING,1,8) = KODE;
    :NEW.ID_BOOKING := KODE || LPAD(JUMLAH,4,'0');
    :NEW.TGL_BOOKING := TO_DATE(SYSDATE,'DD-MM-YYYY HH24:MI:SS');
    :NEW.STATUS_BOOKING = '1';
END;
/

CREATE OR REPLACE TRIGGER INSERTH_PINJAM
BEFORE INSERT ON H_PINJAM
FOR EACH ROW
DECLARE
    JUMLAH NUMBER;
    KODE VARCHAR2(12);
BEGIN
    KODE := TO_CHAR(SYSDATE,'YYYYMMDD');
    SELECT COUNT(*)+1 INTO JUMLAH FROM H_PINJAM WHERE SUBSTR(NOMOR_PINJAM,1,8) = KODE;
    :NEW.NOMOR_PINJAM := KODE || LPAD(JUMLAH,4,'0');
    :NEW.TGL_PINJAM := TO_DATE(SYSDATE,'DD-MM-YYYY');
    :NEW.TGL_BATAS_PINJAM := TO_DATE(SYSDATE+7,'DD-MM-YYYY');
    :NEW.TGL_KEMBALI := NULL;
    :NEW.STATUS_PINJAM :='1';
END;
/

CREATE OR REPLACE TRIGGER INSERTDENDA
BEFORE INSERT ON DENDA
FOR EACH ROW
DECLARE
    JUMLAH NUMBER;
    KODE VARCHAR2(5);
BEGIN
    SELECT COUNT(*)+1 INTO JUMLAH FROM DENDA;
    :NEW.NOMOR_DENDA := 'D' || LPAD(JUMLAH,4,'0');
END;
/