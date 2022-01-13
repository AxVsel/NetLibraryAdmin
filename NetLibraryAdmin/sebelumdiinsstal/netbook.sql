-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 13 Jan 2022 pada 13.31
-- Versi server: 10.4.22-MariaDB
-- Versi PHP: 8.1.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `netbook`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_buku`
--

CREATE TABLE `tb_buku` (
  `id_buku` varchar(10) NOT NULL,
  `id_rak` varchar(6) NOT NULL,
  `judul` varchar(100) NOT NULL,
  `pengarang` varchar(50) NOT NULL,
  `penerbit` varchar(50) NOT NULL,
  `tahun` int(11) NOT NULL,
  `stok` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_buku`
--

INSERT INTO `tb_buku` (`id_buku`, `id_rak`, `judul`, `pengarang`, `penerbit`, `tahun`, `stok`) VALUES
('BK1', 'RK1', 'Trik rahasia master PHP dan MySQLI', 'Naufal ', 'lokomedia', 2014, 3),
('BK10', 'RK3', 'Mengenal Raden Said alias Sunan Kalijaga', 'Naufal ', 'andi offset', 2010, 2),
('BK12', 'RK1', 'Mahir Bahasa Pemrograman PHP dalam 10 hari', 'Yaumil Aksah', 'Lokomedia', 2017, 1),
('BK13', 'RK4', 'Bagai Langit dan Bumi', 'Andrew', 'lokomedia', 2010, 2),
('BK14', 'RK1', 'Trik Rahasia Menjadi Master Wordpress Handal', 'Andrew', 'Asfa Media', 2015, 5),
('BK16', 'RK4', 'Naruto Shippuden episode 495', 'Andrew', 'Hancong Japan', 2016, 2),
('BK17', 'RK1', 'Belajar Pemrograman Web dengan JSP untuk Pemula', 'Andrew', 'Maxicom', 2016, 5),
('BK18', 'RK1', 'Tutorial Masak Sayur Bayam untuk Kraby Patty', 'fuadi', 'Media Kita', 2015, 1),
('BK19', 'RK4', 'Rembulan Bersinar di Hari Minggu', 'lintang', 'Gampang Media', 2014, 2),
('BK2', 'RK4', 'Kancil nyolong timun', 'faizal ', 'media anak', 2008, 3),
('BK20', 'RK4', 'Hafalan Sholat Delisa', 'lintang', 'Media Novel', 2010, 1),
('BK22', 'RK4', 'Negeri Para Bedebah', 'lintang', 'Media Novel', 2018, 10),
('BK23', 'RK4', 'Belajar Dari Air yang Mengalir', 'Yaumil Aksah', 'Media Filsafat', 2010, 5),
('BK24', 'RK1', 'Networking Academy', 'No Name', 'samata Publisher', 2019, 3),
('BK3', 'RK1', 'Proyek website super wow dengan PHP dan JQuery', 'Alan qobus', 'lokomedia', 2012, 5),
('BK4', 'RK2', 'From Zero to Hero', 'No Name', 'Media Islam', 2015, 2),
('BK5', 'RK2', 'The way to win', 'no name', 'Media Islam', 2015, 2),
('BK6', 'RK2', 'Mahir CSS3 & Bootstrap dalam 1 Minggu', 'Yaumil Aksah', 'lokomedia', 2017, 3),
('BK7', 'RK3', 'Sejarah Kerajaan Majapahit', 'Yaumil Aksah', 'andi offset', 2010, 1),
('BK8', 'RK2', 'Kumpulan hadits bukhari lengkap', 'Yaumil Aksah', 'Media islam', 2015, 5),
('BK9', 'RK2', 'Fiqih sunnah untuk wanita', 'no name', 'Media Islam', 2015, 2);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_detail_kembali`
--

CREATE TABLE `tb_detail_kembali` (
  `id_pinjam` int(11) NOT NULL,
  `id_buku` varchar(10) NOT NULL,
  `tipe_denda` varchar(100) NOT NULL,
  `denda` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_detail_kembali`
--

INSERT INTO `tb_detail_kembali` (`id_pinjam`, `id_buku`, `tipe_denda`, `denda`) VALUES
(1, 'BK1', '', 0),
(1, 'BK22', 'buku hilang', 5000),
(1, 'BK23', '', 0),
(10, 'BK22', '', 0),
(10, 'BK18', '', 0),
(13, 'BK22', '', 0),
(13, 'BK19', '', 0),
(14, 'BK8', '', 0),
(14, 'BK23', 'buku hilang', 45000),
(18, 'BK6', '', 0),
(11, 'BK18', '', 0);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_detail_pinjam`
--

CREATE TABLE `tb_detail_pinjam` (
  `id_pinjam` int(11) NOT NULL,
  `id_buku` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_detail_pinjam`
--

INSERT INTO `tb_detail_pinjam` (`id_pinjam`, `id_buku`) VALUES
(1, 'BK1'),
(1, 'BK22'),
(1, 'BK23'),
(4, 'BK22'),
(4, 'BK23'),
(4, 'BK13'),
(5, 'BK18'),
(5, 'BK19'),
(6, 'BK17'),
(7, 'BK9'),
(7, 'BK14'),
(10, 'BK22'),
(10, 'BK18'),
(11, 'BK18'),
(13, 'BK22'),
(13, 'BK19'),
(14, 'BK8'),
(14, 'BK23'),
(15, 'BK22'),
(15, 'BK23'),
(15, 'BK19'),
(16, 'BK22'),
(16, 'BK23'),
(18, 'BK6');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_kembali`
--

CREATE TABLE `tb_kembali` (
  `id_pinjam` int(11) NOT NULL,
  `id_pegawai` varchar(6) NOT NULL,
  `tgl_kembali` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_kembali`
--

INSERT INTO `tb_kembali` (`id_pinjam`, `id_pegawai`, `tgl_kembali`) VALUES
(1, '987654', '2019-01-01'),
(10, '987654', '2019-01-01'),
(13, '987654', '2019-01-01'),
(14, '789011', '2019-01-03'),
(18, '001', '2022-01-13'),
(11, '001', '2022-01-13');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_member`
--

CREATE TABLE `tb_member` (
  `id_member` varchar(6) NOT NULL,
  `nama_lengkap` varchar(50) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `no_telp` varchar(20) NOT NULL,
  `tgl_registrasi` date NOT NULL,
  `aktif` varchar(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_member`
--

INSERT INTO `tb_member` (`id_member`, `nama_lengkap`, `alamat`, `no_telp`, `tgl_registrasi`, `aktif`) VALUES
('1', 'Akbar hart', 'dk gebangarum ds plumpungrejo kec wonoasri madiun, kode pos 63157', '087889987675', '2018-12-01', 'y'),
('10', 'Cici', 'mboh', '90384', '2018-12-04', 'n'),
('11', 'Yaumil aksah', 'bekasi', '08987837486', '2018-12-08', 'y'),
('17', 'muhammad yaumil', 'sulawesi tengah', '0822332322', '2022-01-13', 'y'),
('2', 'Reza rahmat', 'dk gebangarum rt 16 rw 03', '085678564786', '2018-12-01', 'y'),
('3', 'Muhammad  Zelda', 'pacitan', '08357826482', '2018-12-01', 'y'),
('4', ' Naufal ', 'indramayu', '0878978756', '2018-12-01', 'y'),
('5', 'Hanfi asnan', 'dk pelem ds purwosari kec wonoasri madiun, kode pos 63157', '0878978756', '2018-12-01', 'y'),
('6', 'Fuadi Mukhlis', 'dk pelem', '089674563', '2018-12-01', 'y'),
('7', 'Lintang katulistiwa', 'dsn gebangarum kec wonoasri madiun', '0989738783', '2018-12-03', 'y');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_pegawai`
--

CREATE TABLE `tb_pegawai` (
  `id_pegawai` varchar(6) NOT NULL,
  `nama_lengkap` varchar(50) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `no_telp` varchar(20) NOT NULL,
  `passwd` varchar(50) NOT NULL,
  `jabatan` varchar(20) NOT NULL,
  `aktif` varchar(1) NOT NULL DEFAULT 'n'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_pegawai`
--

INSERT INTO `tb_pegawai` (`id_pegawai`, `nama_lengkap`, `alamat`, `no_telp`, `passwd`, `jabatan`, `aktif`) VALUES
('000002', 'hasan', 'jl kaliurang km 2 yogyakarta', '08978353278', 'admin', 'administrator', 'y'),
('001', 'Yaumil aksah', 'Sulawesi Tengah', '0866735545', 'admin', 'administrator', 'y'),
('002', 'hanafi asnan', 'kab. sleman', '083344555444', 'admin', 'pelayanan', 'y'),
('003', 'Lintang pamungkas', 'bekasi', '083334445444', 'admin', 'katalog', 'y'),
('789011', 'Naufal', 'Indramayu', '0898378734', 'user', 'pelayanan', 'y'),
('987654', 'Anan', 'jl monginsidi no 10 kec mangunharjo kota madiun', '08978756485', 'admin', 'katalog', 'y');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_pengunjung`
--

CREATE TABLE `tb_pengunjung` (
  `id_pengunjung` int(11) NOT NULL,
  `member` varchar(1) NOT NULL,
  `id_member` varchar(6) NOT NULL,
  `nama_lengkap` varchar(50) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `tgl_berkunjung` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_pengunjung`
--

INSERT INTO `tb_pengunjung` (`id_pengunjung`, `member`, `id_member`, `nama_lengkap`, `alamat`, `tgl_berkunjung`) VALUES
(1, 'n', '', 'Yaumil aksah', 'bangarum', '2022-01-01'),
(2, 'n', '', 'Yaumil aksah', 'bangarum', '2022-01-01'),
(3, 'n', '', 'Hanfi asnan', 'sobrah', '2022-01-02'),
(4, 'n', '', 'Yaumil aksah', 'bangarum', '2022-01-02'),
(5, 'n', '', 'Yaumil aksah', 'bangarum', '2022-01-02'),
(6, 'y', '1', '', '', '2022-01-03'),
(8, 'n', '', 'rahmat reza', 'wonoasri', '2022-01-03'),
(9, 'y', '5', '', '', '2022-01-03'),
(10, 'y', '2', '', '', '2022-01-06');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_pinjam`
--

CREATE TABLE `tb_pinjam` (
  `id_pinjam` int(11) NOT NULL,
  `id_member` varchar(6) NOT NULL,
  `id_pegawai` varchar(6) NOT NULL,
  `tgl_pinjam` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_pinjam`
--

INSERT INTO `tb_pinjam` (`id_pinjam`, `id_member`, `id_pegawai`, `tgl_pinjam`) VALUES
(1, '2', '987654', '2022-01-01'),
(4, '1', '987654', '2022-01-01'),
(5, '5', '987654', '2022-01-01'),
(6, '11', '987654', '2022-01-01'),
(7, '6', '987654', '2022-01-01'),
(10, '3', '987654', '2022-01-01'),
(11, '3', '987654', '2022-01-01'),
(13, '2', '987654', '2022-01-01'),
(14, '2', '789011', '2022-01-03'),
(15, '2', '789011', '2022-01-05'),
(16, '7', '789011', '2022-01-06'),
(17, '4', '000002', '2022-01-13'),
(18, '17', '001', '2022-01-13');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_rak_buku`
--

CREATE TABLE `tb_rak_buku` (
  `id_rak` varchar(6) NOT NULL,
  `nama_rak_buku` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_rak_buku`
--

INSERT INTO `tb_rak_buku` (`id_rak`, `nama_rak_buku`) VALUES
('RK1', 'rak buku komputer'),
('RK2', 'rak buku agama'),
('RK3', 'rak buku sejarah'),
('RK4', 'rak buku novel / fiksi'),
('RK5', 'rak buku tutorial'),
('RK6', 'rak buku filsafat');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tb_buku`
--
ALTER TABLE `tb_buku`
  ADD PRIMARY KEY (`id_buku`);

--
-- Indeks untuk tabel `tb_member`
--
ALTER TABLE `tb_member`
  ADD PRIMARY KEY (`id_member`);

--
-- Indeks untuk tabel `tb_pegawai`
--
ALTER TABLE `tb_pegawai`
  ADD PRIMARY KEY (`id_pegawai`);

--
-- Indeks untuk tabel `tb_pengunjung`
--
ALTER TABLE `tb_pengunjung`
  ADD PRIMARY KEY (`id_pengunjung`);

--
-- Indeks untuk tabel `tb_pinjam`
--
ALTER TABLE `tb_pinjam`
  ADD PRIMARY KEY (`id_pinjam`);

--
-- Indeks untuk tabel `tb_rak_buku`
--
ALTER TABLE `tb_rak_buku`
  ADD PRIMARY KEY (`id_rak`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `tb_pengunjung`
--
ALTER TABLE `tb_pengunjung`
  MODIFY `id_pengunjung` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT untuk tabel `tb_pinjam`
--
ALTER TABLE `tb_pinjam`
  MODIFY `id_pinjam` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
