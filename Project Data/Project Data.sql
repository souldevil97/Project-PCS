--KATEGORI
INSERT INTO KATEGORI(NAMA_KATEGORI) VALUES ('AGAMA');
INSERT INTO KATEGORI(NAMA_KATEGORI) VALUES ('AKSESORIS KADO DAN PARCEL');
INSERT INTO KATEGORI(NAMA_KATEGORI) VALUES ('ANAK-ANAK');
INSERT INTO KATEGORI(NAMA_KATEGORI) VALUES ('BAHASA DAN KAMUS');
INSERT INTO KATEGORI(NAMA_KATEGORI) VALUES ('BIOGRAFI DAN MEMOAR');

--PENERBIT
INSERT INTO PENERBIT(NAMA_PENERBIT,ALAMAT_PENERBIT,KOTA_PENERBIT,TELP_PENERBIT) VALUES ('Andi Publisher','Manyar Kertoarjo IX No.62, Mojo, Gubeng','Surabaya','0315946730');
INSERT INTO PENERBIT(NAMA_PENERBIT,ALAMAT_PENERBIT,KOTA_PENERBIT,TELP_PENERBIT) VALUES ('Elex Media Komputindo','Ngagel Jaya Indah Brata Jaya No.3-G, Baratajaya, Gubeng', 'Surabaya','0315055237');
INSERT INTO PENERBIT(NAMA_PENERBIT,ALAMAT_PENERBIT,KOTA_PENERBIT,TELP_PENERBIT) VALUES ('Salemba Teknika', 'Babatan Pilang, Blok A2 No.10, Wiyung, Babatan, Wiyung', 'Surabaya','0317521601');
INSERT INTO PENERBIT(NAMA_PENERBIT,ALAMAT_PENERBIT,KOTA_PENERBIT,TELP_PENERBIT) VALUES ('MediaKom','Cempaka Putih, No. 8, CT X Gejayan, 55283, Condongcatur, Kec. Depok, Kabupaten Sleman', 'Yogyakarta','0274555939');
INSERT INTO PENERBIT(NAMA_PENERBIT,ALAMAT_PENERBIT,KOTA_PENERBIT,TELP_PENERBIT) VALUES ('MediaKita','H. Montong No.57, RT.6/RW.2, Ciganjur, Jagakarsa','Jakarta Selatan','02178883030');

--BUKU
INSERT INTO BUKU(ID_PENERBIT,JUDUL_BUKU,COVER_BUKU,TAHUN_TERBIT,ID_KATEGORI,BAWA_PULANG) VALUES ('PUB0001','Pemrograman Database Menggunakan MySQL',NULL,TO_DATE('2016','YYYY'),'K0024',1);
INSERT INTO BUKU(ID_PENERBIT,JUDUL_BUKU,COVER_BUKU,TAHUN_TERBIT,ID_KATEGORI,BAWA_PULANG) VALUES ('PUB0001','Zend Framework: Solusi Mempercepat Pengembangan Aplikasi Berbasis Web Dengan PHP 5.x (+CD)',NULL,TO_DATE('2015','YYYY'),'K0024',1);
INSERT INTO BUKU(ID_PENERBIT,JUDUL_BUKU,COVER_BUKU,TAHUN_TERBIT,ID_KATEGORI,BAWA_PULANG) VALUES ('PUB0001','Dasar Algoritma&Struktur Data Dengan Bahasa Java+Cd',NULL,TO_DATE('2015','YYYY'),'K0024',1);
INSERT INTO BUKU(ID_PENERBIT,JUDUL_BUKU,COVER_BUKU,TAHUN_TERBIT,ID_KATEGORI,BAWA_PULANG) VALUES ('PUB0001','Windows 8.1 Hack, Tips&Trik',NULL,TO_DATE('2015','YYYY'),'K0024',1);
INSERT INTO BUKU(ID_PENERBIT,JUDUL_BUKU,COVER_BUKU,TAHUN_TERBIT,ID_KATEGORI,BAWA_PULANG) VALUES ('PUB0002','Mysql Untuk Pemula',NULL,TO_DATE('2014','YYYY'),'K0024',1);

--PEGAWAI
INSERT INTO PEGAWAI(ID_PEGAWAI,NAMA_PEGAWAI,FOTO_PEGAWAI,ALAMAT_PEGAWAI,TELP_PEGAWAI,TTL_PEGAWAI,JK_PEGAWAI,PASSWORD_PEGAWAI,STATUS_AKTIF) VALUES ('PEG001','JESSLYN CH','','JL PETEMON','08123456789',TO_DATE('10/10/1997','DD-MM-YYYY'),'P','JES123',1);
INSERT INTO PEGAWAI(ID_PEGAWAI,NAMA_PEGAWAI,FOTO_PEGAWAI,ALAMAT_PEGAWAI,TELP_PEGAWAI,TTL_PEGAWAI,JK_PEGAWAI,PASSWORD_PEGAWAI,STATUS_AKTIF) VALUES ('PEG002','RAHEL MOUDY','','JL KLAMPIS','081234567899',TO_DATE('02/10/1997','DD-MM-YYYY'),'P','MOD123',1);
INSERT INTO PEGAWAI(ID_PEGAWAI,NAMA_PEGAWAI,FOTO_PEGAWAI,ALAMAT_PEGAWAI,TELP_PEGAWAI,TTL_PEGAWAI,JK_PEGAWAI,PASSWORD_PEGAWAI,STATUS_AKTIF) VALUES ('PEG003','STEVEN SETIAWAN SALIM','','JL MULYOSARI','0987654320',TO_DATE('3/11/1997','DD-MM-YYYY'),'L','LIM125',1);
INSERT INTO PEGAWAI(ID_PEGAWAI,NAMA_PEGAWAI,FOTO_PEGAWAI,ALAMAT_PEGAWAI,TELP_PEGAWAI,TTL_PEGAWAI,JK_PEGAWAI,PASSWORD_PEGAWAI,STATUS_AKTIF) VALUES ('PEG004','RICHARD SUGIARTO','','JL KERTAJAYA','0123456789',TO_DATE('10/10/1997','DD-MM-YYYY'),'L','RICHSUGIH123',1);
INSERT INTO PEGAWAI(ID_PEGAWAI,NAMA_PEGAWAI,FOTO_PEGAWAI,ALAMAT_PEGAWAI,TELP_PEGAWAI,TTL_PEGAWAI,JK_PEGAWAI,PASSWORD_PEGAWAI,STATUS_AKTIF) VALUES ('PEG005','JEFRI TANWIJAYA','','JL MULYOSARI','0123456789',TO_DATE('10/10/1997','DD-MM-YYYY'),'L','JEF098',1);

--ABSENSI_PEGAWAI
INSERT INTO ABSENSI_PEGAWAI (ID_ABSEN,ID_PEGAWAI,WAKTU_DATANG_ABSEN,WAKTU_PULANG_ABSEN) VALUES ('1','PEG001',TO_DATE('12-04-2017 08.10','DD-MM-YYYY H24:MI'),TO_DATE('12-04-2017 18.11 ','DD-MM-YYYY HH24:MI'));

--PENGARANG
INSERT INTO PENGARANG (ID_PENGARANG,NAMA_PENGARANG) VALUES('AU0001','Dr. Eng. R. H. Sianipar, S. T., M. Eng');
INSERT INTO PENGARANG (ID_PENGARANG,NAMA_PENGARANG) VALUES('AU0002','Edison Siregar');
INSERT INTO PENGARANG (ID_PENGARANG,NAMA_PENGARANG) VALUES('AU0003','Cipta Ramadhani, S.T.,M.Eng');
INSERT INTO PENGARANG (ID_PENGARANG,NAMA_PENGARANG) VALUES('AU0004','Wahana Komputer');
INSERT INTO PENGARANG (ID_PENGARANG,NAMA_PENGARANG) VALUES('AU0005','Jubilee Enterprise');

--BUKU_PENGARANG
INSERT INTO BUKU_PENGARANG (ID_BUKU,ID_PENGARANG) VALUES('B0001','AU0001');
INSERT INTO BUKU_PENGARANG (ID_BUKU,ID_PENGARANG) VALUES('B0002','AU0002');
INSERT INTO BUKU_PENGARANG (ID_BUKU,ID_PENGARANG) VALUES('B0003','AU0003');
INSERT INTO BUKU_PENGARANG (ID_BUKU,ID_PENGARANG) VALUES('B0004','AU0004');
INSERT INTO BUKU_PENGARANG (ID_BUKU,ID_PENGARANG) VALUES('B0005','AU0005');

