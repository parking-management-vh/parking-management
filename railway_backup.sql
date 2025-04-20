parking_area-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: maglev.proxy.rlwy.net    Database: railway
-- ------------------------------------------------------
-- Server version	9.2.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `parking_area`
--

DROP TABLE IF EXISTS `parking_area`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `parking_area` (
  `id` char(36) NOT NULL,
  `area_name` varchar(255) NOT NULL,
  `status` enum('Đầy bãi','Còn chỗ','Sửa chữa') DEFAULT NULL,
  `description` text,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`),
  UNIQUE KEY `unique_area_name` (`area_name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `parking_area`
--

LOCK TABLES `parking_area` WRITE;
/*!40000 ALTER TABLE `parking_area` DISABLE KEYS */;
INSERT INTO `parking_area` VALUES ('20b45e92-bfdb-46d7-9314-7a1d8f97e636','Phương tiện 4 bánh','Còn chỗ','Dành cho các loại ô tô: xe 4 chỗ, xe bán tải, xe 16 chỗ, xe ô tô điện, ...','2025-03-16 10:27:14','2025-03-16 10:27:14'),('a5487c87-0ee1-4861-a597-2d607d33fd43','Phương tiện 2 bánh','Còn chỗ','Dành cho phương tiện 2 bánh: xe thô sơ, xe máy, xe đạp, xe đạp điện, xe máy điện,...','2025-03-16 10:26:12','2025-03-16 10:26:12');
/*!40000 ALTER TABLE `parking_area` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `parking_card`
--

DROP TABLE IF EXISTS `parking_card`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `parking_card` (
  `id` char(36) NOT NULL,
  `start_date` datetime DEFAULT NULL,
  `end_date` datetime DEFAULT NULL,
  `status` enum('Hoạt động','Hết hạn','Không hoạt động') DEFAULT NULL,
  `is_month` tinyint(1) DEFAULT '0',
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `vehicle_id` char(36) DEFAULT NULL,
  `user_id` char(36) DEFAULT NULL,
  `ticket_price_id` char(36) NOT NULL,
  `area_name` varchar(255) DEFAULT NULL,
  `description` text,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`),
  KEY `vehicle_id` (`vehicle_id`),
  KEY `user_id` (`user_id`),
  KEY `fk_parking_card_ticket_price` (`ticket_price_id`),
  CONSTRAINT `fk_parking_card_ticket_price` FOREIGN KEY (`ticket_price_id`) REFERENCES `ticket_price` (`id`),
  CONSTRAINT `parking_card_ibfk_1` FOREIGN KEY (`vehicle_id`) REFERENCES `vehicle` (`id`),
  CONSTRAINT `parking_card_ibfk_2` FOREIGN KEY (`user_id`) REFERENCES `user` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `parking_card`
--

LOCK TABLES `parking_card` WRITE;
/*!40000 ALTER TABLE `parking_card` DISABLE KEYS */;
INSERT INTO `parking_card` VALUES ('186a4c3d-4a7c-422e-a54f-12bdd9bc86d1','2025-03-18 09:52:17','2025-03-18 09:57:35','Hoạt động',0,'2025-03-18 02:52:27','2025-03-18 02:57:37','2acfb9de-0dcc-4bec-a3c2-b06d332fa519',NULL,'88d1226e-025b-11f0-9502-a2aadd329458',NULL,NULL),('27e87657-9352-400f-adcb-c6731862267e','2025-03-17 15:57:36','2025-03-17 15:57:42','Hoạt động',0,'2025-03-17 08:57:37','2025-03-17 08:57:43','cd90a1fd-6a1d-4087-8a34-4462e13bc9dd',NULL,'4f081fa2-025b-11f0-9502-a2aadd329458',NULL,NULL),('3dcdd132-3230-42d0-a636-18e537a8c902','2025-03-17 18:10:14','2025-03-17 18:15:04','Hoạt động',0,'2025-03-17 11:10:17','2025-03-17 11:15:07','42d32910-7497-4719-bd53-257b2dc511d1',NULL,'88d1226e-025b-11f0-9502-a2aadd329458',NULL,NULL),('41011746-f015-4b41-9cce-42f9690dde2b','2025-03-16 23:29:37',NULL,'Hoạt động',0,'2025-03-16 16:29:37','2025-03-16 16:29:37','70630bd0-7c7b-4b08-ac71-4988a7d30537','3cad6eb8-190a-4378-9a22-b2157f4ffd3e','4f081fa2-025b-11f0-9502-a2aadd329458',NULL,NULL),('4478bb1e-b6b4-46d6-b11a-ff08d1fe1d77','2025-03-16 23:28:38',NULL,'Hoạt động',1,'2025-03-16 16:28:39','2025-03-16 16:28:39','46db6023-3c67-4ba1-a87d-e09c6361e619','9d6cefac-d099-4582-a39d-1b299bf8574c','6ed5139e-025b-11f0-9502-a2aadd329458',NULL,NULL),('6163bb53-9483-4a92-bfc3-675434dfbcdf','2025-03-16 23:31:16','2025-03-16 23:34:57','Hoạt động',0,'2025-03-16 16:31:17','2025-03-16 16:34:57','fc9ee501-028a-4cf7-807a-ba6520eeecec',NULL,'25d38353-025c-11f0-9502-a2aadd329458',NULL,NULL),('61fd1246-f396-4291-8a85-ee300cc7735f','2025-03-17 18:16:40','2025-03-17 18:18:51','Hoạt động',0,'2025-03-17 11:16:43','2025-03-17 11:18:53','218a7d99-9364-4abe-aeb9-a44f1aa55d18',NULL,'88d1226e-025b-11f0-9502-a2aadd329458',NULL,NULL),('62993326-2491-4a73-8706-72b716f4c4ef','2025-03-18 09:59:06','2025-03-18 10:01:23','Hoạt động',0,'2025-03-18 02:59:09','2025-03-18 03:01:24','2022b1ab-60b6-446d-97db-34b9d2577e92',NULL,'88d1226e-025b-11f0-9502-a2aadd329458',NULL,NULL),('778434ca-3320-47c6-954a-d50c5afcc78b','2025-03-17 17:51:43','2025-03-17 18:09:06','Hoạt động',0,'2025-03-17 10:51:49','2025-03-17 11:09:10','fa4bd4dd-4a9e-4f66-9356-13e6247802f7',NULL,'88d1226e-025b-11f0-9502-a2aadd329458',NULL,NULL),('91dc0f76-198a-4e1a-84f8-d65169e67736','2025-03-17 18:20:06','2025-03-17 23:21:31','Hoạt động',0,'2025-03-17 11:20:12','2025-03-17 16:21:32','f24ae212-05d0-4a99-94a7-4e7b05e05c16',NULL,'88d1226e-025b-11f0-9502-a2aadd329458',NULL,NULL),('a1e3563f-9d58-4ee4-8df8-98ff32655307','2025-03-16 23:27:07',NULL,'Hoạt động',1,'2025-03-16 16:27:07','2025-03-16 16:27:07','005f96a6-160c-4da8-905b-d5bc7f98a62b','b60bf447-21aa-4361-bc37-8c51565492ea','a94393f6-025b-11f0-9502-a2aadd329458',NULL,NULL),('badfa9ee-5325-45b3-810c-4ca57279edca','2025-03-17 16:03:56','2025-03-17 16:04:04','Hoạt động',0,'2025-03-17 09:03:57','2025-03-17 09:04:04','7b095051-2fed-49ab-8253-15315703a817',NULL,'fca690b2-025a-11f0-9502-a2aadd329458',NULL,NULL),('c0b95a11-49da-47ce-b3c0-83aef7ab4592','2025-03-17 23:43:38','2025-03-17 23:56:45','Hoạt động',0,'2025-03-17 16:43:43','2025-03-17 16:56:46','664f1089-a4d7-49e1-8a6e-5242770a336f',NULL,'88d1226e-025b-11f0-9502-a2aadd329458',NULL,NULL),('ed7b1019-5659-4e38-953f-53449066d94d','2025-03-17 15:54:38','2025-03-17 15:57:42','Hoạt động',0,'2025-03-17 08:54:39','2025-03-17 08:57:43','cd90a1fd-6a1d-4087-8a34-4462e13bc9dd',NULL,'4f081fa2-025b-11f0-9502-a2aadd329458',NULL,NULL),('f1550293-43cb-498f-b0e5-ddad0a59c95b','2025-03-18 00:08:10','2025-03-18 09:42:14','Hoạt động',0,'2025-03-17 17:08:13','2025-03-18 02:42:15','167c0f8f-1650-4966-888f-7fef8f23c50f',NULL,'88d1226e-025b-11f0-9502-a2aadd329458',NULL,NULL),('fa103ffd-fe8b-4574-866d-672d44dce105','2025-03-17 15:58:36','2025-03-17 16:04:04','Hoạt động',0,'2025-03-17 08:58:37','2025-03-17 09:04:04','7b095051-2fed-49ab-8253-15315703a817',NULL,'fca690b2-025a-11f0-9502-a2aadd329458',NULL,NULL);
/*!40000 ALTER TABLE `parking_card` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `parking_slot`
--

DROP TABLE IF EXISTS `parking_slot`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `parking_slot` (
  `id` char(36) NOT NULL,
  `slot_number` int DEFAULT NULL,
  `slot_type` enum('Nhỏ','Vừa','Lớn') DEFAULT NULL,
  `status` enum('Sẵn sàng','Đã có xe','Sửa chữa') DEFAULT NULL,
  `parking_area_id` char(36) DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`),
  UNIQUE KEY `unique_slot_per_area` (`slot_number`,`parking_area_id`),
  KEY `parking_area_id` (`parking_area_id`),
  CONSTRAINT `parking_slot_ibfk_1` FOREIGN KEY (`parking_area_id`) REFERENCES `parking_area` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `parking_slot`
--

LOCK TABLES `parking_slot` WRITE;
/*!40000 ALTER TABLE `parking_slot` DISABLE KEYS */;
INSERT INTO `parking_slot` VALUES ('00f3a74e-9884-40ff-9001-9bea9740ad8a',17,'Vừa','Đã có xe','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-16 10:50:06','2025-03-17 10:14:12'),('0624d336-6057-4e53-8b0b-24ef5d388a05',16,'Vừa','Đã có xe','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-16 10:47:59','2025-03-17 10:45:23'),('0a00c657-15ef-4507-ad31-96e25e3d6ae2',1,'Lớn','Đã có xe','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-16 10:48:23','2025-03-17 08:51:34'),('0ac1ec46-773d-4054-95a7-787901d3b91c',12,'Vừa','Sẵn sàng','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-16 10:47:31','2025-03-16 10:47:31'),('0cdc196c-3cdd-4671-8d36-aaa8e01cfad0',19,'Lớn','Sẵn sàng','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-16 10:51:19','2025-03-17 17:06:39'),('1f5a5b34-8533-41f4-b76b-3908ab1b64d9',3,'Lớn','Sẵn sàng','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-16 10:48:43','2025-03-17 16:21:23'),('220a0114-ff72-4d81-91f7-532fed344f2b',7,'Vừa','Sẵn sàng','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-16 10:46:46','2025-03-17 08:50:27'),('24fbe309-38dc-423c-85d4-b923fa2d650b',20,'Lớn','Sửa chữa','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-16 10:51:24','2025-03-16 10:52:16'),('2d610a0a-3968-4895-a408-057a07b62258',2,'Vừa','Đã có xe','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-16 10:46:05','2025-03-16 16:23:15'),('3ab4b21a-06e4-4db1-9eb5-1816a7656502',10,'Lớn','Sửa chữa','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-16 10:50:32','2025-03-16 10:52:16'),('4c279751-505e-4754-9021-0c9a280af16c',10,'Vừa','Sẵn sàng','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-16 10:47:15','2025-03-16 10:47:15'),('4f45eb31-61ac-4372-adcb-20709ae1eaa8',16,'Lớn','Đã có xe','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-16 10:51:04','2025-03-17 08:50:28'),('5657e58c-0f4c-42d2-983e-ca3279d55517',5,'Vừa','Sẵn sàng','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-16 10:46:29','2025-03-17 08:50:28'),('5db4a518-ea31-467f-bec0-88d1b5590401',20,'Vừa','Sửa chữa','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-16 10:50:27','2025-03-16 10:50:27'),('6b018841-d28c-4691-8008-cef78a05e2c2',7,'Lớn','Sẵn sàng','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-16 10:50:15','2025-03-18 03:00:10'),('6e41a0fa-9fde-4b47-a0db-df550ac124fe',1,'Vừa','Đã có xe','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-16 10:45:59','2025-03-16 16:22:51'),('707028b3-056e-454b-860b-603ebbe8b13e',13,'Lớn','Sẵn sàng','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-16 10:50:49','2025-03-16 10:50:49'),('7a44363c-6eab-4f9c-b882-1dd2cb29f9d8',12,'Lớn','Sẵn sàng','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-16 10:50:43','2025-03-16 10:50:43'),('7a603f90-0d9b-4a91-b09e-94ac0579e3cc',3,'Vừa','Đã có xe','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-16 10:46:12','2025-03-17 10:35:23'),('81cc4865-1c38-4e6c-b4ef-de1fecb9bb5e',9,'Lớn','Sẵn sàng','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-16 10:50:26','2025-03-18 02:54:16'),('8bd40fc5-ff1e-45b1-bf0f-f743ee17a62d',6,'Lớn','Sẵn sàng','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-16 10:49:04','2025-03-17 08:50:30'),('8cbc7be4-a4f6-4154-97a9-8f78f3cfcc60',19,'Vừa','Sửa chữa','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-16 10:50:20','2025-03-16 10:50:20'),('8f52d6e5-79dc-4057-89e0-061535f7dbb3',2,'Lớn','Đã có xe','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-16 10:48:34','2025-03-17 03:41:13'),('940da887-5723-42d0-850e-fe783d2e970b',8,'Lớn','Sẵn sàng','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-16 10:50:21','2025-03-16 10:50:21'),('976cadf8-76a3-49b4-9ecc-23c7864346c1',4,'Vừa','Sẵn sàng','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-16 10:46:23','2025-03-17 08:26:44'),('9f83506d-9d77-4612-ab54-b7154427ef83',13,'Vừa','Sẵn sàng','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-16 10:47:39','2025-03-16 10:47:39'),('ab8d1be9-7f73-4e67-8a44-75e15e5b0a37',14,'Lớn','Sẵn sàng','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-16 10:50:55','2025-03-16 10:50:55'),('afb20aa3-9cd9-4dea-a2d5-b58220246d7b',8,'Vừa','Đã có xe','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-16 10:46:55','2025-03-17 10:44:50'),('b54e4dcf-a779-4438-b3e9-241af896190f',5,'Lớn','Sẵn sàng','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-16 10:48:55','2025-03-17 08:50:32'),('b60ee0f5-76d8-4206-85be-335a502bd732',15,'Lớn','Đã có xe','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-16 10:50:59','2025-03-17 17:26:13'),('b84ad7fd-0557-4192-b12e-6ac6512b73d8',14,'Vừa','Sẵn sàng','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-16 10:47:46','2025-03-16 10:47:46'),('b8b737ac-9eef-4bdb-a245-e81ee4bb1867',18,'Vừa','Sẵn sàng','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-16 10:50:13','2025-03-16 10:50:13'),('b9b45e50-da2d-4e05-a201-94206973f6ae',15,'Vừa','Sẵn sàng','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-16 10:47:53','2025-03-16 10:47:53'),('c025c3d1-1d26-41bc-a863-0d04f0dacaf0',11,'Lớn','Sẵn sàng','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-16 10:50:37','2025-03-16 10:50:37'),('c317642d-4794-4c70-8274-c8aafd5315a7',17,'Lớn','Sẵn sàng','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-16 10:51:08','2025-03-16 10:51:08'),('d0f801bf-464f-4bf0-9ec0-6525c82c3224',9,'Vừa','Sẵn sàng','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-16 10:47:06','2025-03-16 10:47:06'),('d569b1dc-89e6-45b8-bd44-bc5e05f2a12b',6,'Vừa','Sẵn sàng','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-16 10:46:36','2025-03-17 08:50:32'),('e183f668-4c25-4566-805e-ed185a6e7e66',18,'Lớn','Sẵn sàng','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-16 10:51:13','2025-03-17 16:49:56'),('ed205982-2881-4d98-9c29-5a3510a6fffb',4,'Lớn','Sẵn sàng','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-16 10:48:50','2025-03-17 08:50:33'),('f6f6b39d-49bf-48d0-a8a5-761af4940ed6',11,'Vừa','Sẵn sàng','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-16 10:47:22','2025-03-16 10:47:22');
/*!40000 ALTER TABLE `parking_slot` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payment_receipt`
--

DROP TABLE IF EXISTS `payment_receipt`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `payment_receipt` (
  `id` int NOT NULL AUTO_INCREMENT,
  `parking_card_id` char(36) DEFAULT NULL,
  `payment_date` datetime DEFAULT NULL,
  `total_price` decimal(10,2) DEFAULT NULL,
  `payment_method` enum('Tiền mặt','Thẻ','Chuyển khoản') DEFAULT NULL,
  `total_time` int DEFAULT NULL,
  `vehicle_id` char(36) DEFAULT NULL,
  `staff_code` varchar(255) DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `payment_status` enum('Chờ duyệt','Hoàn tất','Hủy') DEFAULT 'Hoàn tất',
  `invoice_code` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`),
  UNIQUE KEY `invoice_code` (`invoice_code`),
  KEY `staff_code` (`staff_code`),
  KEY `fk_payment_receipt_parking_card` (`parking_card_id`),
  KEY `fk_payment_receipt_vehicle` (`vehicle_id`),
  CONSTRAINT `fk_payment_receipt_parking_card` FOREIGN KEY (`parking_card_id`) REFERENCES `parking_card` (`id`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `fk_payment_receipt_vehicle` FOREIGN KEY (`vehicle_id`) REFERENCES `vehicle` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `payment_receipt_ibfk_3` FOREIGN KEY (`staff_code`) REFERENCES `user` (`code`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment_receipt`
--

LOCK TABLES `payment_receipt` WRITE;
/*!40000 ALTER TABLE `payment_receipt` DISABLE KEYS */;
INSERT INTO `payment_receipt` VALUES (1,'6163bb53-9483-4a92-bfc3-675434dfbcdf','2025-03-16 16:34:59',0.00,'Tiền mặt',0,'fc9ee501-028a-4cf7-807a-ba6520eeecec','AD2503161729','2025-03-16 16:34:59','2025-03-16 16:34:59','Hoàn tất','HD2503162334'),(2,'a1e3563f-9d58-4ee4-8df8-98ff32655307','2025-03-16 16:36:05',2000000.00,'Tiền mặt',30,'005f96a6-160c-4da8-905b-d5bc7f98a62b','AD2503161729','2025-03-16 16:36:05','2025-03-16 16:36:05','Hoàn tất','HD2503162336'),(3,'ed7b1019-5659-4e38-953f-53449066d94d','2025-03-17 08:56:32',0.00,'Tiền mặt',0,'cd90a1fd-6a1d-4087-8a34-4462e13bc9dd','AD2503170923','2025-03-17 08:56:32','2025-03-17 08:56:32','Hoàn tất','HD2503171556'),(4,'fa103ffd-fe8b-4574-866d-672d44dce105','2025-03-17 09:02:01',15000.00,'Tiền mặt',3,'7b095051-2fed-49ab-8253-15315703a817','AD2503170923','2025-03-17 09:02:01','2025-03-17 09:02:01','Hoàn tất','HD2503171602'),(6,'778434ca-3320-47c6-954a-d50c5afcc78b','2025-03-17 10:57:35',0.00,'Tiền mặt',0,'fa4bd4dd-4a9e-4f66-9356-13e6247802f7','AD2503161729','2025-03-17 10:57:35','2025-03-17 10:57:35','Hoàn tất','HD2503171757'),(7,'778434ca-3320-47c6-954a-d50c5afcc78b','2025-03-17 11:09:12',20000.00,'Thẻ',1,'fa4bd4dd-4a9e-4f66-9356-13e6247802f7','AD2503161729','2025-03-17 11:09:12','2025-03-17 11:09:12','Hoàn tất','HD2503171809'),(8,'3dcdd132-3230-42d0-a636-18e537a8c902','2025-03-17 11:15:08',0.00,'Chuyển khoản',0,'42d32910-7497-4719-bd53-257b2dc511d1','AD2503161729','2025-03-17 11:15:08','2025-03-17 11:15:08','Hoàn tất','HD2503171815'),(9,'91dc0f76-198a-4e1a-84f8-d65169e67736','2025-03-17 15:51:19',100000.00,'Tiền mặt',5,'f24ae212-05d0-4a99-94a7-4e7b05e05c16','AD2503161729','2025-03-17 15:51:19','2025-03-17 15:51:19','Hoàn tất','HD2503172251'),(11,'c0b95a11-49da-47ce-b3c0-83aef7ab4592','2025-03-17 16:50:26',0.00,'Thẻ',0,'664f1089-a4d7-49e1-8a6e-5242770a336f','123','2025-03-17 16:50:26','2025-03-17 16:50:26','Hoàn tất','HD2503172350'),(12,'f1550293-43cb-498f-b0e5-ddad0a59c95b','2025-03-17 17:11:47',0.00,'Thẻ',0,'167c0f8f-1650-4966-888f-7fef8f23c50f','123','2025-03-17 17:11:47','2025-03-17 17:11:47','Hoàn tất','HD2503180011'),(13,'f1550293-43cb-498f-b0e5-ddad0a59c95b','2025-03-17 18:58:03',40000.00,'Thẻ',2,'167c0f8f-1650-4966-888f-7fef8f23c50f','123','2025-03-17 18:58:03','2025-03-17 18:58:03','Hoàn tất','HD2503180157'),(14,'186a4c3d-4a7c-422e-a54f-12bdd9bc86d1','2025-03-18 02:57:43',0.00,'Thẻ',0,'2acfb9de-0dcc-4bec-a3c2-b06d332fa519','123','2025-03-18 02:57:43','2025-03-18 02:57:43','Hoàn tất','HD2503180957'),(15,'62993326-2491-4a73-8706-72b716f4c4ef','2025-03-18 03:01:30',120000.00,'Thẻ',6,'2022b1ab-60b6-446d-97db-34b9d2577e92','123','2025-03-18 03:01:30','2025-03-18 03:01:30','Hoàn tất','HD2503181001');
/*!40000 ALTER TABLE `payment_receipt` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `role` (
  `id` char(36) NOT NULL,
  `role_name` varchar(15) DEFAULT NULL,
  `description` varchar(255) DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role` VALUES ('510c27c9-48dd-42f5-8cca-8cc1fadec68f','Manager','Quản lý một bãi đỗ xe nhất định','2025-03-16 10:36:59','2025-03-16 10:36:59'),('b20ca6a6-48ef-492b-b067-9fe9ff69badf','Admin','Admin quản trị hệ thống, có tất cả quyền','2025-03-16 10:14:08','2025-03-16 10:14:08'),('d1f3abbd-c89e-4bd9-83a2-a8b729dd547b','Customer','Khánh hàng đăng ký theo vé tháng','2025-03-16 10:37:31','2025-03-16 10:37:31');
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ticket_price`
--

DROP TABLE IF EXISTS `ticket_price`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ticket_price` (
  `id` char(36) NOT NULL DEFAULT (uuid()),
  `price` decimal(10,2) DEFAULT NULL,
  `is_month` tinyint(1) DEFAULT '0',
  `description` text,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `vehicle_type_id` char(36) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`),
  KEY `fk_ticket_vehicle` (`vehicle_type_id`),
  CONSTRAINT `fk_ticket_vehicle` FOREIGN KEY (`vehicle_type_id`) REFERENCES `vehicle_type` (`id`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ticket_price`
--

LOCK TABLES `ticket_price` WRITE;
/*!40000 ALTER TABLE `ticket_price` DISABLE KEYS */;
INSERT INTO `ticket_price` VALUES ('038208ef-025c-11f0-9502-a2aadd329458',3000000.00,1,'3000000đ/1tháng xe ô tô 7 chỗ vé tháng','2025-03-16 11:44:26','2025-03-16 11:44:26','8164f15f-0259-11f0-9502-a2aadd329458'),('11783420-025b-11f0-9502-a2aadd329458',150000.00,1,'150000đ/3h xe đạp điện vé tháng','2025-03-16 11:37:40','2025-03-16 11:37:40','d5ce3684-0258-11f0-9502-a2aadd329458'),('25d38353-025c-11f0-9502-a2aadd329458',40000.00,0,'40000đ/3h xe ô tô 16 chỗ vé ngày','2025-03-16 11:45:24','2025-03-16 11:45:24','44728a79-025a-11f0-9502-a2aadd329458'),('28d2c112-025b-11f0-9502-a2aadd329458',3000.00,0,'3000đ/3h xe thô sơ vé ngày','2025-03-16 11:38:19','2025-03-16 11:38:19','d5ce2ec0-0258-11f0-9502-a2aadd329458'),('3afd840f-025c-11f0-9502-a2aadd329458',4000000.00,1,'4000000đ/1tháng xe ô tô 16 chỗ vé tháng','2025-03-16 11:45:59','2025-03-16 11:45:59','44728a79-025a-11f0-9502-a2aadd329458'),('3ffd1b46-025b-11f0-9502-a2aadd329458',10000000.00,1,'100000đ/tháng xe thô sơ vé tháng','2025-03-16 11:38:58','2025-03-16 11:46:44','d5ce2ec0-0258-11f0-9502-a2aadd329458'),('4f081fa2-025b-11f0-9502-a2aadd329458',5000.00,0,'5000đ/3h xe máy vé ngày','2025-03-16 11:39:23','2025-03-16 11:39:23','d5ce34f5-0258-11f0-9502-a2aadd329458'),('6ed5139e-025b-11f0-9502-a2aadd329458',200000.00,1,'200000đ/tháng xe máy vé tháng','2025-03-16 11:40:17','2025-03-16 11:40:17','d5ce34f5-0258-11f0-9502-a2aadd329458'),('88d1226e-025b-11f0-9502-a2aadd329458',20000.00,0,'20000đ/3h xe ô tô 4 chỗ vé ngày','2025-03-16 11:41:00','2025-03-16 11:41:00','923b1833-0259-11f0-9502-a2aadd329458'),('962e288a-025a-11f0-9502-a2aadd329458',3000.00,0,'3000đ/1h xe đạp vé ngày','2025-03-16 11:34:13','2025-03-16 11:34:13','d5ce3623-0258-11f0-9502-a2aadd329458'),('a94393f6-025b-11f0-9502-a2aadd329458',2000000.00,1,'2000000đ/1tháng xe ô tô 4 chỗ vé tháng','2025-03-16 11:41:55','2025-03-16 11:41:55','923b1833-0259-11f0-9502-a2aadd329458'),('bde3c688-025b-11f0-9502-a2aadd329458',20000.00,0,'20000đ/3h xe bán tải vé ngày','2025-03-16 11:42:29','2025-03-16 11:42:29','892143bc-0259-11f0-9502-a2aadd329458'),('d2f8fc21-025b-11f0-9502-a2aadd329458',2000000.00,1,'2000000đ/1tháng xe bán tải vé tháng','2025-03-16 11:43:05','2025-03-16 11:43:05','892143bc-0259-11f0-9502-a2aadd329458'),('dd92d194-025a-11f0-9502-a2aadd329458',100000.00,1,'100000đ/1h xe đạp vé tháng','2025-03-16 11:36:13','2025-03-16 11:36:13','d5ce3623-0258-11f0-9502-a2aadd329458'),('f06cc31a-025b-11f0-9502-a2aadd329458',30000.00,0,'30000đ/3h xe ô tô 7 chỗ vé ngày','2025-03-16 11:43:54','2025-03-16 11:43:54','8164f15f-0259-11f0-9502-a2aadd329458'),('fca690b2-025a-11f0-9502-a2aadd329458',5000.00,0,'5000đ/3h xe đạp điện vé ngày','2025-03-16 11:37:05','2025-03-16 11:37:05','d5ce3684-0258-11f0-9502-a2aadd329458');
/*!40000 ALTER TABLE `ticket_price` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `id` char(36) NOT NULL,
  `code` varchar(255) DEFAULT NULL,
  `full_name` varchar(255) DEFAULT NULL,
  `date_of_birth` date DEFAULT NULL,
  `gender` enum('Nam','Nữ') DEFAULT NULL,
  `phone_number` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `address` text,
  `password` varchar(255) DEFAULT NULL,
  `role_id` char(36) DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `area_id` char(36) DEFAULT NULL,
  `status` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`),
  UNIQUE KEY `code` (`code`),
  KEY `role_id` (`role_id`),
  KEY `fk_user_area` (`area_id`),
  CONSTRAINT `fk_user_area` FOREIGN KEY (`area_id`) REFERENCES `parking_area` (`id`),
  CONSTRAINT `user_ibfk_1` FOREIGN KEY (`role_id`) REFERENCES `role` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES ('10ab28e7-072d-47e3-a9fd-61eaebe3dd55','KH2503170855','Đoàn Hà My','2011-03-02','Nữ','0986738867','hamy@gmail.com','Tân Phong, Ninh Giang, Hải Dương','123456','d1f3abbd-c89e-4bd9-83a2-a8b729dd547b','2025-03-17 01:55:58','2025-03-17 02:03:21','a5487c87-0ee1-4861-a597-2d607d33fd43',1),('226951a4-4aa4-44b1-ad9c-576dbe5aab10','KH2503170857','Đoàn Dự','2010-03-17','Nam','0989372546','doandu21@gmail.com','Tân Phong, Ninh Giang , Hải Dương','123456','d1f3abbd-c89e-4bd9-83a2-a8b729dd547b','2025-03-17 01:57:58','2025-03-17 02:03:21','a5487c87-0ee1-4861-a597-2d607d33fd43',1),('2986cc1c-7d00-43b0-9b35-c51bbe56a997','KH2503170920','Sơn Tùng','1999-02-02','Nam','0234111222','mtp@gmail.com','Thành phố Thái Bình, Việt Nam','123456','d1f3abbd-c89e-4bd9-83a2-a8b729dd547b','2025-03-16 10:39:15','2025-03-17 09:20:58','20b45e92-bfdb-46d7-9314-7a1d8f97e636',1),('2bc0ec62-ff81-4326-b06d-4db3c3d52e29','USER2503170919','Hồ Ngọc Hà','1996-01-01','Nữ','0234555666','hnh@gmail.com','Thành phố Hồ Chí Minh, Việt Nam','123456','510c27c9-48dd-42f5-8cca-8cc1fadec68f','2025-03-16 10:43:46','2025-03-17 09:19:13','20b45e92-bfdb-46d7-9314-7a1d8f97e636',1),('3275a831-ddfd-4c4b-8770-d44b66cf34bc','KH2503170913','Tô Lâm','1957-07-10','Nam','0987654322','tolam97@gmail.com','Nghĩa Trụ, Văn Giang, Hưng Yên',NULL,'d1f3abbd-c89e-4bd9-83a2-a8b729dd547b','2025-03-17 02:13:12','2025-03-17 02:13:12','20b45e92-bfdb-46d7-9314-7a1d8f97e636',1),('3cad6eb8-190a-4378-9a22-b2157f4ffd3e','AD2503170920','Trinh Khanh','2003-07-24','Nam','0234333666','khanh@gmail.com','Gia Lai, Hải Dương, Hưng Yên, Hà Nội','123456','b20ca6a6-48ef-492b-b067-9fe9ff69badf','2025-03-16 10:31:31','2025-03-17 09:20:03','20b45e92-bfdb-46d7-9314-7a1d8f97e636',1),('54d91a9b-d800-40e6-8b8f-c6298778608d','KH2503170917','Lương Cường','1957-08-15','Nam','0347284714','luongcuong@gmail.com','Dữu Lâu, Việt Trì, Phú Thọ',NULL,'d1f3abbd-c89e-4bd9-83a2-a8b729dd547b','2025-03-17 02:17:37','2025-03-17 02:17:37','20b45e92-bfdb-46d7-9314-7a1d8f97e636',1),('854a9466-bd20-4674-8d99-5e51844e1a96','KH2503170923','Trịnh Trần P.Tuấn','1997-07-07','Nam','0234222000','pt@gmail.com','Bến Tre, thành phố Hồ Chí Minh','123456','d1f3abbd-c89e-4bd9-83a2-a8b729dd547b','2025-03-16 10:40:08','2025-03-17 09:23:04','20b45e92-bfdb-46d7-9314-7a1d8f97e636',1),('9d6cefac-d099-4582-a39d-1b299bf8574c','AD2503170923','Dang Hong','2003-05-21','Nữ','0234666888','hong@gmail.com','Nguyễn Uý, Kim Bảng, Hà Nam','123456','b20ca6a6-48ef-492b-b067-9fe9ff69badf','2025-03-16 10:30:25','2025-03-17 09:23:31','a5487c87-0ee1-4861-a597-2d607d33fd43',1),('a403ab73-a763-40f9-9922-cae2bbd1e8db','KH2503170911','Phạm Minh Chính','1958-12-10','Nam','0937744556','chinh32@gmail.com','Hoa Lộc, Hậu Lộc, Thanh Hóa',NULL,'d1f3abbd-c89e-4bd9-83a2-a8b729dd547b','2025-03-17 02:11:06','2025-03-17 02:11:06','20b45e92-bfdb-46d7-9314-7a1d8f97e636',1),('ae099908-ed9a-487f-8996-2160e1da9cbe','KH2503170907','Đặng Đình Lâm','1980-03-17','Nam','0987654321','lam83@gmail.com','Quỳnh Lâm, Hà Nam, Việt Nam',NULL,'d1f3abbd-c89e-4bd9-83a2-a8b729dd547b','2025-03-17 02:07:32','2025-03-17 02:07:32','20b45e92-bfdb-46d7-9314-7a1d8f97e636',1),('b2325040-4a63-4814-a827-9b84e653fe72','KH2503170924','Hoàng Anh Thư','2001-01-01','Nam','0234333111','at@gmail.com','Bắc Ninh, Việt Nam, Thế Giới','123456','d1f3abbd-c89e-4bd9-83a2-a8b729dd547b','2025-03-16 10:38:28','2025-03-17 09:24:12','a5487c87-0ee1-4861-a597-2d607d33fd43',1),('b60bf447-21aa-4361-bc37-8c51565492ea','AD2503161729','Duc Hai','2003-02-08','Nam','0345888999','hai@gmail.com','Ninh Giang - Hải Dương','123456','b20ca6a6-48ef-492b-b067-9fe9ff69badf','2025-03-16 10:29:33','2025-03-16 10:45:01','20b45e92-bfdb-46d7-9314-7a1d8f97e636',1),('cf7b19e2-eb6a-4e42-aaab-0129babe6cd6','USER2503170925','Mỹ Tâm','1993-03-03','Nữ','0234999111','mt@gmail.com','Ninh Giang, Hải Dương, Hà Nội','123456','510c27c9-48dd-42f5-8cca-8cc1fadec68f','2025-03-16 10:40:53','2025-03-17 09:25:58','a5487c87-0ee1-4861-a597-2d607d33fd43',1),('e916835a-14f6-40fd-9ca9-7a5136adff49','123','test','1999-01-01','Nam','1234567890','test@gmail.com','test','123','b20ca6a6-48ef-492b-b067-9fe9ff69badf','2025-03-17 15:47:12','2025-03-17 15:47:35','20b45e92-bfdb-46d7-9314-7a1d8f97e636',1),('f89e7af4-c038-4ca4-a3de-06d341d53f2a','KH2503170901','Trịnh Hớn Hở','2003-03-20','Nam','0937478469','honho21@gmail.com','Giáp Nhị, Hoàng Mai, Hà Nội','123456','d1f3abbd-c89e-4bd9-83a2-a8b729dd547b','2025-03-17 02:01:38','2025-03-17 02:03:22','20b45e92-bfdb-46d7-9314-7a1d8f97e636',1);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicle`
--

DROP TABLE IF EXISTS `vehicle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vehicle` (
  `id` char(36) NOT NULL,
  `license_plate` varchar(255) DEFAULT NULL,
  `vehicle_type_id` char(36) DEFAULT NULL,
  `parking_slot_id` char(36) DEFAULT NULL,
  `parking_area_id` char(36) DEFAULT NULL,
  `entry_time` datetime DEFAULT NULL,
  `exit_time` datetime DEFAULT NULL,
  `save_time` datetime DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `status` enum('parked','exited') DEFAULT 'parked',
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`),
  KEY `vehicle_type_id` (`vehicle_type_id`),
  KEY `parking_slot_id` (`parking_slot_id`),
  KEY `parking_area_id` (`parking_area_id`),
  CONSTRAINT `vehicle_ibfk_1` FOREIGN KEY (`vehicle_type_id`) REFERENCES `vehicle_type` (`id`),
  CONSTRAINT `vehicle_ibfk_2` FOREIGN KEY (`parking_slot_id`) REFERENCES `parking_slot` (`id`),
  CONSTRAINT `vehicle_ibfk_3` FOREIGN KEY (`parking_area_id`) REFERENCES `parking_area` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle`
--

LOCK TABLES `vehicle` WRITE;
/*!40000 ALTER TABLE `vehicle` DISABLE KEYS */;
INSERT INTO `vehicle` VALUES ('005f96a6-160c-4da8-905b-d5bc7f98a62b','34E1-88888','923b1833-0259-11f0-9502-a2aadd329458','0a00c657-15ef-4507-ad31-96e25e3d6ae2','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-16 23:23:55',NULL,'2025-03-16 23:23:55','2025-03-16 23:23:55','2025-03-16 16:25:35','parked'),('167c0f8f-1650-4966-888f-7fef8f23c50f','55A5-55559','923b1833-0259-11f0-9502-a2aadd329458','81cc4865-1c38-4e6c-b4ef-de1fecb9bb5e','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-18 00:07:55','2025-03-18 02:42:13','2025-03-18 00:07:55','2025-03-18 00:07:55','2025-03-18 02:42:13','exited'),('2022b1ab-60b6-446d-97db-34b9d2577e92','55A5-55559','923b1833-0259-11f0-9502-a2aadd329458','6b018841-d28c-4691-8008-cef78a05e2c2','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-18 09:58:57','2025-03-18 03:01:22','2025-03-18 09:58:57','2025-03-18 09:58:57','2025-03-18 03:01:34','exited'),('218a7d99-9364-4abe-aeb9-a44f1aa55d18','55A5-55558','923b1833-0259-11f0-9502-a2aadd329458','1f5a5b34-8533-41f4-b76b-3908ab1b64d9','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-17 18:16:36','2025-03-17 11:18:50','2025-03-17 18:16:36','2025-03-17 18:16:36','2025-03-17 11:18:50','parked'),('2acfb9de-0dcc-4bec-a3c2-b06d332fa519','55A5-55559','923b1833-0259-11f0-9502-a2aadd329458','6b018841-d28c-4691-8008-cef78a05e2c2','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-18 09:52:03','2025-03-18 02:57:34','2025-03-18 09:52:03','2025-03-18 09:52:03','2025-03-18 02:57:48','exited'),('364cd12c-da90-4f7d-9a7c-561e94e02fcf','90F1-77777','8164f15f-0259-11f0-9502-a2aadd329458','8f52d6e5-79dc-4057-89e0-061535f7dbb3','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-17 10:41:11',NULL,'2025-03-17 10:41:11','2025-03-17 10:41:11','2025-03-17 10:41:11','parked'),('42d32910-7497-4719-bd53-257b2dc511d1','55A5-55557','923b1833-0259-11f0-9502-a2aadd329458','1f5a5b34-8533-41f4-b76b-3908ab1b64d9','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-17 18:10:10','2025-03-17 11:15:06','2025-03-17 18:10:10','2025-03-17 18:10:10','2025-03-17 11:15:06','parked'),('46db6023-3c67-4ba1-a87d-e09c6361e619','34E1-99999','d5ce34f5-0258-11f0-9502-a2aadd329458','2d610a0a-3968-4895-a408-057a07b62258','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-16 23:23:14',NULL,'2025-03-16 23:23:14','2025-03-16 23:23:14','2025-03-16 23:23:14','parked'),('664f1089-a4d7-49e1-8a6e-5242770a336f','55A5-55559','923b1833-0259-11f0-9502-a2aadd329458','e183f668-4c25-4566-805e-ed185a6e7e66','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-17 23:25:29','2025-03-17 16:56:43','2025-03-17 23:25:29','2025-03-17 23:25:29','2025-03-17 16:56:43','exited'),('70630bd0-7c7b-4b08-ac71-4988a7d30537','34E1-22222','d5ce34f5-0258-11f0-9502-a2aadd329458','6e41a0fa-9fde-4b47-a0db-df550ac124fe','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-16 23:22:50',NULL,'2025-03-16 23:22:50','2025-03-16 23:22:50','2025-03-16 23:22:50','parked'),('7b095051-2fed-49ab-8253-15315703a817','23A2-76345','d5ce3684-0258-11f0-9502-a2aadd329458','afb20aa3-9cd9-4dea-a2d5-b58220246d7b','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-17 15:58:29','2025-03-17 09:04:03','2025-03-17 15:58:29','2025-03-17 15:58:29','2025-03-17 09:04:03','parked'),('952d8e10-6e66-4c90-83f3-f2bf09ed86c2','11A1-11111','d5ce34f5-0258-11f0-9502-a2aadd329458','0624d336-6057-4e53-8b0b-24ef5d388a05','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-17 17:27:10',NULL,'2025-03-17 17:27:10','2025-03-17 17:14:11','2025-03-17 17:27:10','parked'),('cd90a1fd-6a1d-4087-8a34-4462e13bc9dd','66B8-42463','d5ce34f5-0258-11f0-9502-a2aadd329458','7a603f90-0d9b-4a91-b09e-94ac0579e3cc','a5487c87-0ee1-4861-a597-2d607d33fd43','2025-03-17 15:54:33','2025-03-17 08:57:42','2025-03-17 15:54:33','2025-03-17 15:54:33','2025-03-17 08:57:42','parked'),('f248e8fd-6abd-45af-9aa4-ff44812e5d6d','55A5-55559','923b1833-0259-11f0-9502-a2aadd329458','b60ee0f5-76d8-4206-85be-335a502bd732','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-18 00:26:07','2025-03-18 00:26:07','2025-03-18 00:26:07','2025-03-18 00:26:07','2025-03-18 03:02:33','exited'),('f24ae212-05d0-4a99-94a7-4e7b05e05c16','55A5-55559','923b1833-0259-11f0-9502-a2aadd329458','1f5a5b34-8533-41f4-b76b-3908ab1b64d9','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-17 18:19:53','2025-03-17 16:21:30','2025-03-17 18:19:53','2025-03-17 18:19:53','2025-03-17 16:21:40','exited'),('fa4bd4dd-4a9e-4f66-9356-13e6247802f7','55A5-55556','923b1833-0259-11f0-9502-a2aadd329458','1f5a5b34-8533-41f4-b76b-3908ab1b64d9','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-17 17:59:17','2025-03-17 11:09:08','2025-03-17 17:59:17','2025-03-17 17:51:30','2025-03-17 11:09:08','parked'),('fc9ee501-028a-4cf7-807a-ba6520eeecec','99E1-99999','44728a79-025a-11f0-9502-a2aadd329458','0cdc196c-3cdd-4671-8d36-aaa8e01cfad0','20b45e92-bfdb-46d7-9314-7a1d8f97e636','2025-03-17 18:14:05',NULL,'2025-03-17 18:14:05','2025-03-16 23:31:12','2025-03-17 18:14:05','parked');
/*!40000 ALTER TABLE `vehicle` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicle_type`
--

DROP TABLE IF EXISTS `vehicle_type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vehicle_type` (
  `id` char(36) NOT NULL DEFAULT (uuid()),
  `vehicle_type_name` varchar(50) NOT NULL,
  `description` text,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle_type`
--

LOCK TABLES `vehicle_type` WRITE;
/*!40000 ALTER TABLE `vehicle_type` DISABLE KEYS */;
INSERT INTO `vehicle_type` VALUES ('44728a79-025a-11f0-9502-a2aadd329458','Ô tô 16 chỗ','Ô tô có 16 chỗ ngồi: limousin,...','2025-03-16 11:31:56','2025-03-16 11:31:56'),('8164f15f-0259-11f0-9502-a2aadd329458','Ô tô 7 chỗ','Xe ô tô có 7 chỗ ngồi','2025-03-16 11:26:29','2025-03-16 11:26:29'),('892143bc-0259-11f0-9502-a2aadd329458','Ô tô bán tải','Xe bán tải, có thùng sau','2025-03-16 11:26:42','2025-03-16 11:26:42'),('923b1833-0259-11f0-9502-a2aadd329458','Ô tô 4 chỗ','Xe ô tô có 4 chỗ ngồi','2025-03-16 11:26:57','2025-03-16 11:26:57'),('d5ce2ec0-0258-11f0-9502-a2aadd329458','Xe thô sơ','Xe không động cơ như xe đạp','2025-03-16 11:21:41','2025-03-16 11:21:41'),('d5ce34f5-0258-11f0-9502-a2aadd329458','Xe máy','Xe moto hai bánh','2025-03-16 11:21:41','2025-03-16 11:21:41'),('d5ce3623-0258-11f0-9502-a2aadd329458','Xe đạp','Xe đạp thông thường','2025-03-16 11:21:41','2025-03-16 11:21:41'),('d5ce3684-0258-11f0-9502-a2aadd329458','Xe đạp điện','Xe đạp có hỗ trợ động cơ điện','2025-03-16 11:21:41','2025-03-16 11:21:41');
/*!40000 ALTER TABLE `vehicle_type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'railway'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-03-18 12:44:19
