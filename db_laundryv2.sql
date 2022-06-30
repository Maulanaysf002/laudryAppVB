/*
SQLyog Ultimate v12.4.3 (64 bit)
MySQL - 10.4.22-MariaDB : Database - db_laundryv2
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`db_laundryv2` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;

USE `db_laundryv2`;

/*Table structure for table `data_laundry` */

DROP TABLE IF EXISTS `data_laundry`;

CREATE TABLE `data_laundry` (
  `faktur` varchar(11) NOT NULL,
  `nama_pelanggan` varchar(100) NOT NULL,
  `berat_cucian` int(5) NOT NULL,
  `harga` int(11) NOT NULL,
  `panjar` int(11) NOT NULL,
  `keterangan` varchar(15) NOT NULL,
  `sisa_tagihan` int(11) NOT NULL,
  `estimasi_selesai` varchar(20) NOT NULL,
  PRIMARY KEY (`faktur`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `data_laundry` */

insert  into `data_laundry`(`faktur`,`nama_pelanggan`,`berat_cucian`,`harga`,`panjar`,`keterangan`,`sisa_tagihan`,`estimasi_selesai`) values 
('2006220004','sekar',8,64000,20000,'Belum Lunas',44000,'22 June 2022'),
('2006220005','gilang',3,24000,12000,'Belum Lunas',12000,'22 June 2022');

/*Table structure for table `data_laundry_selesai` */

DROP TABLE IF EXISTS `data_laundry_selesai`;

CREATE TABLE `data_laundry_selesai` (
  `faktur` varchar(10) NOT NULL,
  `nama_pelanggan` varchar(100) NOT NULL,
  `berat_cucian` int(5) NOT NULL,
  `harga` int(11) NOT NULL,
  `keterangan` varchar(15) NOT NULL,
  `tanggal_selesai` varchar(20) NOT NULL,
  `Status` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `data_laundry_selesai` */

insert  into `data_laundry_selesai`(`faktur`,`nama_pelanggan`,`berat_cucian`,`harga`,`keterangan`,`tanggal_selesai`,`Status`) values 
('2006220001','farhan',7,56000,'Lunas','20 June 2022','selesai'),
('2006220002','melli',5,40000,'Lunas','20 June 2022','selesai'),
('2006220003','lastri',10,80000,'Lunas','20 June 2022','selesai');

/*Table structure for table `users` */

DROP TABLE IF EXISTS `users`;

CREATE TABLE `users` (
  `username` varchar(15) NOT NULL,
  `password` varchar(15) NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

/*Data for the table `users` */

insert  into `users`(`username`,`password`) values 
('admin1','admin1');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
