-- phpMyAdmin SQL Dump
-- version 4.0.4.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jul 03, 2020 at 07:59 AM
-- Server version: 5.5.32
-- PHP Version: 5.4.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `hms_lhs`
--
CREATE DATABASE IF NOT EXISTS `hms_lhs` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `hms_lhs`;

-- --------------------------------------------------------

--
-- Table structure for table `account_group`
--

CREATE TABLE IF NOT EXISTS `account_group` (
  `account_group_id` int(11) NOT NULL AUTO_INCREMENT,
  `account_group_name` varchar(100) NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL,
  `updated_by` int(100) DEFAULT NULL,
  `updated_on` datetime DEFAULT NULL,
  PRIMARY KEY (`account_group_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `account_group`
--

INSERT INTO `account_group` (`account_group_id`, `account_group_name`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, 'AC REGISTER', 'user', '2020-07-01 21:57:34', 0, '2020-07-02 15:49:04'),
(2, 'COURIER', 'user', '2020-07-01 22:08:54', 0, '2020-07-02 15:49:13'),
(3, 'CLEANING MATERIALS', 'user', '2020-07-01 22:11:12', 0, '2020-07-02 15:49:25'),
(4, 'ARASAN GAS(EMPTY CYLINDER RECEIPT BILL)', 'user', '2020-07-02 15:48:52', NULL, NULL),
(5, 'test', 'user', '2020-07-03 07:19:59', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `backup`
--

CREATE TABLE IF NOT EXISTS `backup` (
  `id` int(5) NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `path` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `billing_ecg_xray`
--

CREATE TABLE IF NOT EXISTS `billing_ecg_xray` (
  `billing_ecg_xray_id` int(3) NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `patient_id` int(6) NOT NULL,
  `test_id` int(4) NOT NULL,
  `doctor_id` int(3) NOT NULL,
  `fees` double(10,2) NOT NULL,
  `section` varchar(50) NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL,
  `updated_by` varchar(100) DEFAULT NULL,
  `updated_on` datetime DEFAULT NULL,
  PRIMARY KEY (`billing_ecg_xray_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `billing_lab`
--

CREATE TABLE IF NOT EXISTS `billing_lab` (
  `lab_id` int(5) NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `patient_id` bigint(8) NOT NULL,
  `doctor_id` int(3) NOT NULL,
  `total_amount` double(10,2) NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL,
  `updated_by` varchar(100) DEFAULT NULL,
  `updated_on` datetime DEFAULT NULL,
  PRIMARY KEY (`lab_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `billing_lab_details`
--

CREATE TABLE IF NOT EXISTS `billing_lab_details` (
  `lab_id` int(6) NOT NULL,
  `txno` int(3) NOT NULL,
  `test_id` int(3) NOT NULL,
  `patient_test_details` varchar(500) NOT NULL,
  `amount` double(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `billing_scan`
--

CREATE TABLE IF NOT EXISTS `billing_scan` (
  `scan_id` int(5) NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `patient_id` bigint(10) NOT NULL,
  `doctor_id` int(3) NOT NULL,
  `test_id` int(4) NOT NULL,
  `fees` double(10,2) NOT NULL,
  `doctor_suggestion` varchar(500) NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL,
  `updated_by` varchar(100) DEFAULT NULL,
  `updated_on` datetime DEFAULT NULL,
  PRIMARY KEY (`scan_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `config`
--

CREATE TABLE IF NOT EXISTS `config` (
  `config_id` int(1) NOT NULL,
  `is_hms` varchar(10) NOT NULL,
  `is_accounts` varchar(10) NOT NULL,
  `is_batch` varchar(10) NOT NULL,
  `is_expiry` varchar(10) NOT NULL,
  `backup_path` varchar(100) NOT NULL,
  `is_m_hsn_code` varchar(10) NOT NULL,
  `is_m_product_name_in_tamil` varchar(10) NOT NULL,
  `is_m_product_code` varchar(10) NOT NULL,
  PRIMARY KEY (`config_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `config`
--

INSERT INTO `config` (`config_id`, `is_hms`, `is_accounts`, `is_batch`, `is_expiry`, `backup_path`, `is_m_hsn_code`, `is_m_product_name_in_tamil`, `is_m_product_code`) VALUES
(0, 'NO', 'NO', 'NO', 'NO', 'D:\\SoftwareBackup', 'NO', 'NO', 'NO');

-- --------------------------------------------------------

--
-- Table structure for table `inv_purchase_return`
--

CREATE TABLE IF NOT EXISTS `inv_purchase_return` (
  `returndate` date NOT NULL,
  `itemno` int(5) NOT NULL,
  `inv_no` int(5) NOT NULL,
  `return_qty` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `inv_sales_return`
--

CREATE TABLE IF NOT EXISTS `inv_sales_return` (
  `returndate` date NOT NULL,
  `itemno` int(5) NOT NULL,
  `inv_no` int(5) NOT NULL,
  `return_qty` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `ip_admission`
--

CREATE TABLE IF NOT EXISTS `ip_admission` (
  `ipno` int(5) NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `patient_id` int(5) NOT NULL,
  `doctor_id` int(3) NOT NULL,
  `case_type_id` int(4) NOT NULL,
  `room_id` int(4) NOT NULL,
  `admitted_by` varchar(100) NOT NULL,
  `is_paid` tinyint(1) NOT NULL,
  `is_discharged` tinyint(1) NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL,
  `updated_by` varchar(100) DEFAULT NULL,
  `updated_on` datetime DEFAULT NULL,
  PRIMARY KEY (`ipno`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `ip_advance_payment`
--

CREATE TABLE IF NOT EXISTS `ip_advance_payment` (
  `advance_payment_id` int(6) NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `ipno` int(6) NOT NULL,
  `amount` double(10,2) NOT NULL,
  PRIMARY KEY (`advance_payment_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `ip_discharge_entry`
--

CREATE TABLE IF NOT EXISTS `ip_discharge_entry` (
  `ip_discharge_entry_id` int(6) NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `ipno` int(6) NOT NULL,
  `admission_condition` varchar(500) NOT NULL,
  `investigation_done` varchar(500) NOT NULL,
  `treatement_given` varchar(500) NOT NULL,
  `clinical_course` varchar(500) NOT NULL,
  `discharge_condition` varchar(500) NOT NULL,
  `discharge_advice` varchar(500) NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL,
  `updated_by` varchar(100) DEFAULT NULL,
  `updated_on` datetime DEFAULT NULL,
  PRIMARY KEY (`ip_discharge_entry_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `ip_invoice`
--

CREATE TABLE IF NOT EXISTS `ip_invoice` (
  `ip_invoice_id` int(6) NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `ipno` int(6) NOT NULL,
  `sub_amount` double(10,2) NOT NULL,
  `advance_amount` double(10,2) NOT NULL,
  `less_amount` double(10,2) NOT NULL,
  `total_amount` double(10,2) NOT NULL,
  `created_by` varchar(100) DEFAULT NULL,
  `created_on` datetime DEFAULT NULL,
  `updated_by` varchar(100) NOT NULL,
  `updated_on` datetime DEFAULT NULL,
  PRIMARY KEY (`ip_invoice_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `ip_invoice_details`
--

CREATE TABLE IF NOT EXISTS `ip_invoice_details` (
  `ip_invoice_id` int(6) NOT NULL,
  `txno` int(6) NOT NULL,
  `particulars` varchar(150) NOT NULL,
  `amount` double(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `m_case_type`
--

CREATE TABLE IF NOT EXISTS `m_case_type` (
  `case_type_id` int(4) NOT NULL AUTO_INCREMENT,
  `case_type_name` varchar(100) NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL,
  `updated_by` int(100) DEFAULT NULL,
  `updated_on` datetime DEFAULT NULL,
  PRIMARY KEY (`case_type_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=302 ;

--
-- Dumping data for table `m_case_type`
--

INSERT INTO `m_case_type` (`case_type_id`, `case_type_name`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, 'Delivery', '', '0000-00-00 00:00:00', NULL, NULL),
(2, 'SUGAR', '', '0000-00-00 00:00:00', NULL, NULL),
(3, 'HYSTERECTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(4, 'VARICOCELEY', '', '0000-00-00 00:00:00', NULL, NULL),
(5, 'FITZ', '', '0000-00-00 00:00:00', NULL, NULL),
(6, 'NEW   BORN', '', '0000-00-00 00:00:00', NULL, NULL),
(7, 'ECTOBIC', '', '0000-00-00 00:00:00', NULL, NULL),
(8, 'BABY CASE', '', '0000-00-00 00:00:00', NULL, NULL),
(9, '4MONTHS', '', '0000-00-00 00:00:00', NULL, NULL),
(10, 'LAP CHOLE', '', '0000-00-00 00:00:00', NULL, NULL),
(11, 'WHEZZING', '', '0000-00-00 00:00:00', NULL, NULL),
(12, 'FEVER', '', '0000-00-00 00:00:00', NULL, NULL),
(13, 'OVAREIAN CYST', '', '0000-00-00 00:00:00', NULL, NULL),
(14, 'BLOOD TRANSFUSSION', '', '0000-00-00 00:00:00', NULL, NULL),
(15, '6MONTHS', '', '0000-00-00 00:00:00', NULL, NULL),
(16, 'PIH', '', '0000-00-00 00:00:00', NULL, NULL),
(17, 'RE-STITCH', '', '0000-00-00 00:00:00', NULL, NULL),
(18, 'DIAGNOSTIC LAP', '', '0000-00-00 00:00:00', NULL, NULL),
(19, 'STEND REMOVAL', '', '0000-00-00 00:00:00', NULL, NULL),
(20, 'SPOTTING', '', '0000-00-00 00:00:00', NULL, NULL),
(21, 'CX STITCH', '', '0000-00-00 00:00:00', NULL, NULL),
(22, 'HERNIA', '', '0000-00-00 00:00:00', NULL, NULL),
(23, 'BILAT.PCOD', '', '0000-00-00 00:00:00', NULL, NULL),
(24, 'D&C', '', '0000-00-00 00:00:00', NULL, NULL),
(25, 'LS', '', '0000-00-00 00:00:00', NULL, NULL),
(26, 'ORTHO', '', '0000-00-00 00:00:00', NULL, NULL),
(27, '8 MONTH', '', '0000-00-00 00:00:00', NULL, NULL),
(28, 'BLEEDING', '', '0000-00-00 00:00:00', NULL, NULL),
(29, 'GENERAL', '', '0000-00-00 00:00:00', NULL, NULL),
(30, 'CHEMOTHEROPHY', '', '0000-00-00 00:00:00', NULL, NULL),
(31, 'APPENDIX', '', '0000-00-00 00:00:00', NULL, NULL),
(32, 'MYOMECTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(33, 'BREAST', '', '0000-00-00 00:00:00', NULL, NULL),
(34, 'END BIOPSY', '', '0000-00-00 00:00:00', NULL, NULL),
(35, 'DRIP', '', '0000-00-00 00:00:00', NULL, NULL),
(36, 'PILES', '', '0000-00-00 00:00:00', NULL, NULL),
(37, 'M.T.P', '', '0000-00-00 00:00:00', NULL, NULL),
(38, '7MONTHS', '', '0000-00-00 00:00:00', NULL, NULL),
(39, 'RENAL CALCULUS', '', '0000-00-00 00:00:00', NULL, NULL),
(40, 'PS', '', '0000-00-00 00:00:00', NULL, NULL),
(41, 'GIDDINESS', '', '0000-00-00 00:00:00', NULL, NULL),
(42, 'STOCK', '', '0000-00-00 00:00:00', NULL, NULL),
(43, 'H LAP', '', '0000-00-00 00:00:00', NULL, NULL),
(44, 'BEREAST', '', '0000-00-00 00:00:00', NULL, NULL),
(45, 'PLEEDING', '', '0000-00-00 00:00:00', NULL, NULL),
(46, '5MONTH', '', '0000-00-00 00:00:00', NULL, NULL),
(47, 'ABD.PAIN', '', '0000-00-00 00:00:00', NULL, NULL),
(48, 'DIARIYA', '', '0000-00-00 00:00:00', NULL, NULL),
(49, 'VOMITING', '', '0000-00-00 00:00:00', NULL, NULL),
(50, 'BABY WARMER', '', '0000-00-00 00:00:00', NULL, NULL),
(51, 'HISTROLAB', '', '0000-00-00 00:00:00', NULL, NULL),
(52, 'IUD', '', '0000-00-00 00:00:00', NULL, NULL),
(53, '2MOUNTH', '', '0000-00-00 00:00:00', NULL, NULL),
(54, 'URINE', '', '0000-00-00 00:00:00', NULL, NULL),
(55, 'POLYPECTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(56, 'MTP&LS', '', '0000-00-00 00:00:00', NULL, NULL),
(57, 'JUANDICE', '', '0000-00-00 00:00:00', NULL, NULL),
(58, 'D&C LS', '', '0000-00-00 00:00:00', NULL, NULL),
(59, 'HEMO THERPY', '', '0000-00-00 00:00:00', NULL, NULL),
(60, 'BREATHING', '', '0000-00-00 00:00:00', NULL, NULL),
(61, 'VERICOCLE', '', '0000-00-00 00:00:00', NULL, NULL),
(62, 'STOMACK PAIN', '', '0000-00-00 00:00:00', NULL, NULL),
(63, 'DRESSING', '', '0000-00-00 00:00:00', NULL, NULL),
(64, 'STONE', '', '0000-00-00 00:00:00', NULL, NULL),
(65, 'CX.STICH', '', '0000-00-00 00:00:00', NULL, NULL),
(66, 'CALCULAS', '', '0000-00-00 00:00:00', NULL, NULL),
(67, 'L.S', '', '0000-00-00 00:00:00', NULL, NULL),
(68, 'BP', '', '0000-00-00 00:00:00', NULL, NULL),
(69, 'ST0NE', '', '0000-00-00 00:00:00', NULL, NULL),
(70, 'RECONSLATION', '', '0000-00-00 00:00:00', NULL, NULL),
(71, 'REMOVALENDPOLY', '', '0000-00-00 00:00:00', NULL, NULL),
(72, 'TERMINATION', '', '0000-00-00 00:00:00', NULL, NULL),
(73, 'CEVICALSTITCH', '', '0000-00-00 00:00:00', NULL, NULL),
(74, 'ABSEESS', '', '0000-00-00 00:00:00', NULL, NULL),
(75, 'VESICULAR  MOLE', '', '0000-00-00 00:00:00', NULL, NULL),
(76, 'HERNIA&TERMINATION', '', '0000-00-00 00:00:00', NULL, NULL),
(77, '9  MONTH', '', '0000-00-00 00:00:00', NULL, NULL),
(78, '9MONTHS &B.P', '', '0000-00-00 00:00:00', NULL, NULL),
(79, '6MONTHS&BLEEDING', '', '0000-00-00 00:00:00', NULL, NULL),
(80, 'HIPPALN', '', '0000-00-00 00:00:00', NULL, NULL),
(81, 'MTP&TAT', '', '0000-00-00 00:00:00', NULL, NULL),
(82, 'DESTOSCOPY', '', '0000-00-00 00:00:00', NULL, NULL),
(83, 'FIBROADEMA', '', '0000-00-00 00:00:00', NULL, NULL),
(84, 'CYSTECTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(85, 'SKIN  PROBLEM', '', '0000-00-00 00:00:00', NULL, NULL),
(86, 'FISTULLA', '', '0000-00-00 00:00:00', NULL, NULL),
(87, 'PERNIAL ABCESS', '', '0000-00-00 00:00:00', NULL, NULL),
(88, 'MISSED ABORTION', '', '0000-00-00 00:00:00', NULL, NULL),
(89, 'CA BLADDER', '', '0000-00-00 00:00:00', NULL, NULL),
(90, '8 MONTHS', '', '0000-00-00 00:00:00', NULL, NULL),
(91, 'STRESSING  CONSISTENCY', '', '0000-00-00 00:00:00', NULL, NULL),
(92, 'CIRCUMCENSCENION', '', '0000-00-00 00:00:00', NULL, NULL),
(93, '3  MONTH', '', '0000-00-00 00:00:00', NULL, NULL),
(94, 'MTP LS', '', '0000-00-00 00:00:00', NULL, NULL),
(95, 'B.P', '', '0000-00-00 00:00:00', NULL, NULL),
(96, 'CIRCUMSATION', '', '0000-00-00 00:00:00', NULL, NULL),
(97, 'HYSTEROSCOPIC', '', '0000-00-00 00:00:00', NULL, NULL),
(98, 'PSYCHATERISM', '', '0000-00-00 00:00:00', NULL, NULL),
(99, 'LIYPOMA', '', '0000-00-00 00:00:00', NULL, NULL),
(100, 'SPTUM DISSECTION', '', '0000-00-00 00:00:00', NULL, NULL),
(101, 'KIDNEY  PROBLEM', '', '0000-00-00 00:00:00', NULL, NULL),
(102, 'LAP CYST', '', '0000-00-00 00:00:00', NULL, NULL),
(103, '3MONTHS BLEEDING', '', '0000-00-00 00:00:00', NULL, NULL),
(104, 'CUT', '', '0000-00-00 00:00:00', NULL, NULL),
(105, 'CA BREAST', '', '0000-00-00 00:00:00', NULL, NULL),
(106, 'CUT-RE    ( LAP)', '', '0000-00-00 00:00:00', NULL, NULL),
(107, 'UMBLICALHERNIA', '', '0000-00-00 00:00:00', NULL, NULL),
(108, 'TRIP', '', '0000-00-00 00:00:00', NULL, NULL),
(109, 'THYROID', '', '0000-00-00 00:00:00', NULL, NULL),
(110, 'LIPOMA', '', '0000-00-00 00:00:00', NULL, NULL),
(111, 'MTP TAT', '', '0000-00-00 00:00:00', NULL, NULL),
(112, 'LOOSE MOTION', '', '0000-00-00 00:00:00', NULL, NULL),
(113, 'VEGINAL WIDING', '', '0000-00-00 00:00:00', NULL, NULL),
(114, 'CUT REMOVE  TAT', '', '0000-00-00 00:00:00', NULL, NULL),
(115, 'LAP CYSTECTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(116, 'CX. POLIP', '', '0000-00-00 00:00:00', NULL, NULL),
(117, 'I&D', '', '0000-00-00 00:00:00', NULL, NULL),
(118, 'CVA', '', '0000-00-00 00:00:00', NULL, NULL),
(119, 'LAP CHOLECYSTECTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(120, 'BREAST MASS', '', '0000-00-00 00:00:00', NULL, NULL),
(121, 'HYDROCILE', '', '0000-00-00 00:00:00', NULL, NULL),
(122, 'WOUND HEELING', '', '0000-00-00 00:00:00', NULL, NULL),
(123, 'GTT', '', '0000-00-00 00:00:00', NULL, NULL),
(124, 'GDM', '', '0000-00-00 00:00:00', NULL, NULL),
(125, 'PLONIDAL ABSCESS', '', '0000-00-00 00:00:00', NULL, NULL),
(126, 'PAIN', '', '0000-00-00 00:00:00', NULL, NULL),
(127, 'ASCITIES', '', '0000-00-00 00:00:00', NULL, NULL),
(128, 'IUI', '', '0000-00-00 00:00:00', NULL, NULL),
(129, 'LAP CHOLEHYSTECTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(130, 'ENTRICFEVER', '', '0000-00-00 00:00:00', NULL, NULL),
(131, 'AMBLICAL HER &  HYST', '', '0000-00-00 00:00:00', NULL, NULL),
(132, 'TISSUE MASS BLADDER', '', '0000-00-00 00:00:00', NULL, NULL),
(133, 'CHEST PAIN', '', '0000-00-00 00:00:00', NULL, NULL),
(134, 'SLING  REMOVAL', '', '0000-00-00 00:00:00', NULL, NULL),
(135, 'HYDROCEPHALAS', '', '0000-00-00 00:00:00', NULL, NULL),
(136, 'EAR  SWELLING', '', '0000-00-00 00:00:00', NULL, NULL),
(137, 'STEM CELL COLLECTION', '', '0000-00-00 00:00:00', NULL, NULL),
(138, 'BREAST ABCESS', '', '0000-00-00 00:00:00', NULL, NULL),
(139, 'SAFE  PRAGNENCY', '', '0000-00-00 00:00:00', NULL, NULL),
(140, 'GLUTEAL SEBACCOUS', '', '0000-00-00 00:00:00', NULL, NULL),
(141, 'VEG. INF', '', '0000-00-00 00:00:00', NULL, NULL),
(142, 'VERTIGO', '', '0000-00-00 00:00:00', NULL, NULL),
(143, 'ST. INF', '', '0000-00-00 00:00:00', NULL, NULL),
(144, 'DIAGNOSTIC LAP  & CYSTECTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(145, 'PERINIAL SWELLING', '', '0000-00-00 00:00:00', NULL, NULL),
(146, 'N.I.C.U', '', '0000-00-00 00:00:00', NULL, NULL),
(147, 'LEG WOUND', '', '0000-00-00 00:00:00', NULL, NULL),
(148, 'GB CALCULUS', '', '0000-00-00 00:00:00', NULL, NULL),
(149, 'LAP.MYOMECTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(150, 'ABD.CYST', '', '0000-00-00 00:00:00', NULL, NULL),
(151, 'ENDOSCOPY', '', '0000-00-00 00:00:00', NULL, NULL),
(152, 'TONGE  TIE', '', '0000-00-00 00:00:00', NULL, NULL),
(153, 'TYPHOID', '', '0000-00-00 00:00:00', NULL, NULL),
(154, 'VEG.CYST', '', '0000-00-00 00:00:00', NULL, NULL),
(155, 'C.V.A', '', '0000-00-00 00:00:00', NULL, NULL),
(156, 'BATHOLIN  CYST', '', '0000-00-00 00:00:00', NULL, NULL),
(157, 'COLD', '', '0000-00-00 00:00:00', NULL, NULL),
(158, 'CYSTOCOLE', '', '0000-00-00 00:00:00', NULL, NULL),
(159, 'CERVICAL CYST', '', '0000-00-00 00:00:00', NULL, NULL),
(160, 'BREAST LUMP', '', '0000-00-00 00:00:00', NULL, NULL),
(161, 'LOOSE  STOOLS', '', '0000-00-00 00:00:00', NULL, NULL),
(162, 'PERINOTEMY', '', '0000-00-00 00:00:00', NULL, NULL),
(163, 'TAT', '', '0000-00-00 00:00:00', NULL, NULL),
(164, 'CHOCOLATE CYST', '', '0000-00-00 00:00:00', NULL, NULL),
(165, 'CX.BIOPSY', '', '0000-00-00 00:00:00', NULL, NULL),
(166, 'OVAREIAN CYST @ HYST', '', '0000-00-00 00:00:00', NULL, NULL),
(167, 'LAPROSCOPY / LAPROTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(168, 'SWELLING IN BREAST', '', '0000-00-00 00:00:00', NULL, NULL),
(169, 'STITCH PROBLEM', '', '0000-00-00 00:00:00', NULL, NULL),
(170, 'CX STITCH  REMOVED', '', '0000-00-00 00:00:00', NULL, NULL),
(171, 'TESTICULAR BIOPSY', '', '0000-00-00 00:00:00', NULL, NULL),
(172, 'ENDOMETRIOTIC CYST', '', '0000-00-00 00:00:00', NULL, NULL),
(173, 'CHOCOLATE CYSTECTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(174, 'ENDOMETRIOTIC CYST[LAP CUSTY]', '', '0000-00-00 00:00:00', NULL, NULL),
(175, 'OVARY MASS', '', '0000-00-00 00:00:00', NULL, NULL),
(176, 'VIRAL HEPATITIS', '', '0000-00-00 00:00:00', NULL, NULL),
(177, 'CHOCHOLECYSTECTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(178, 'INFECTION', '', '0000-00-00 00:00:00', NULL, NULL),
(179, 'FISSURE', '', '0000-00-00 00:00:00', NULL, NULL),
(180, 'LAP CHOLETCYST', '', '0000-00-00 00:00:00', NULL, NULL),
(181, 'D&C & TAT', '', '0000-00-00 00:00:00', NULL, NULL),
(182, 'CUT REMOVE LS', '', '0000-00-00 00:00:00', NULL, NULL),
(183, '3 MONTHS ', '', '0000-00-00 00:00:00', NULL, NULL),
(184, '3  MONTHS', '', '0000-00-00 00:00:00', NULL, NULL),
(185, 'BIOPSY', '', '0000-00-00 00:00:00', NULL, NULL),
(186, 'CALCULAS CHOLECYSTITIS', '', '0000-00-00 00:00:00', NULL, NULL),
(187, 'HYSTERECTOMY & PILES', '', '0000-00-00 00:00:00', NULL, NULL),
(188, 'HYSTROSCOPY &  POLYP REMOVAL', '', '0000-00-00 00:00:00', NULL, NULL),
(189, 'BARTHOLIN S ABSCESS', '', '0000-00-00 00:00:00', NULL, NULL),
(190, 'URETHRAL POLYP', '', '0000-00-00 00:00:00', NULL, NULL),
(191, 'B.P. CONTROL', '', '0000-00-00 00:00:00', NULL, NULL),
(192, 'LAP. APPENDISECTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(193, 'SEPTAL RESECTION', '', '0000-00-00 00:00:00', NULL, NULL),
(194, 'PFR', '', '0000-00-00 00:00:00', NULL, NULL),
(195, 'URINARY INFECTION', '', '0000-00-00 00:00:00', NULL, NULL),
(196, 'RECANALISATION', '', '0000-00-00 00:00:00', NULL, NULL),
(197, 'LAP SURGERY', '', '0000-00-00 00:00:00', NULL, NULL),
(198, 'D&C & GA', '', '0000-00-00 00:00:00', NULL, NULL),
(199, 'LAP OVAREIAN CYSTECTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(200, 'BLOOD TRANSFUSSION @ D&C', '', '0000-00-00 00:00:00', NULL, NULL),
(201, 'URINE PROBLEM', '', '0000-00-00 00:00:00', NULL, NULL),
(202, 'DELIVERY OUT SIDEBABY C.T.V', '', '0000-00-00 00:00:00', NULL, NULL),
(203, 'DIAGNOSTIC LAP & MYOMECTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(204, '7MONTHS IUD & HYSTECTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(205, 'SURGERY', '', '0000-00-00 00:00:00', NULL, NULL),
(206, 'DERMOID CYST', '', '0000-00-00 00:00:00', NULL, NULL),
(207, 'CERVICAL POLYP', '', '0000-00-00 00:00:00', NULL, NULL),
(208, 'HYPERTROPY@HEART', '', '0000-00-00 00:00:00', NULL, NULL),
(209, 'AXILLA', '', '0000-00-00 00:00:00', NULL, NULL),
(210, 'END. POLYP', '', '0000-00-00 00:00:00', NULL, NULL),
(211, 'HERBERS', '', '0000-00-00 00:00:00', NULL, NULL),
(212, 'TORSION TESTIS', '', '0000-00-00 00:00:00', NULL, NULL),
(213, 'HERNIA @ VARICOCELE', '', '0000-00-00 00:00:00', NULL, NULL),
(214, 'HERNIA  REPAIR', '', '0000-00-00 00:00:00', NULL, NULL),
(215, 'TRACTION', '', '0000-00-00 00:00:00', NULL, NULL),
(216, 'MTP & TAT', '', '0000-00-00 00:00:00', NULL, NULL),
(217, 'LAP. DERMOID CYST', '', '0000-00-00 00:00:00', NULL, NULL),
(218, 'MTP @ VEG CYST', '', '0000-00-00 00:00:00', NULL, NULL),
(219, 'FIBROIDEVTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(220, '2MOUNTHS', '', '0000-00-00 00:00:00', NULL, NULL),
(221, '6MONTHS IUD', '', '0000-00-00 00:00:00', NULL, NULL),
(222, 'BEREAST CASE', '', '0000-00-00 00:00:00', NULL, NULL),
(223, '8 MONTHS @ DIARIYA', '', '0000-00-00 00:00:00', NULL, NULL),
(224, 'NEPHRECTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(225, 'GALL BLADDER STONE', '', '0000-00-00 00:00:00', NULL, NULL),
(226, 'SUGAR CONTROL', '', '0000-00-00 00:00:00', NULL, NULL),
(227, 'DISTENTION', '', '0000-00-00 00:00:00', NULL, NULL),
(228, 'ADNEXAL CYST', '', '0000-00-00 00:00:00', NULL, NULL),
(229, 'LAP CHOLE ', '', '0000-00-00 00:00:00', NULL, NULL),
(230, 'BACK PAIN', '', '0000-00-00 00:00:00', NULL, NULL),
(231, 'WOUND INFECTION', '', '0000-00-00 00:00:00', NULL, NULL),
(232, 'URITHERAL  CALCULAS', '', '0000-00-00 00:00:00', NULL, NULL),
(233, 'CHOLECYSTECTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(234, 'CYST REMOVAL', '', '0000-00-00 00:00:00', NULL, NULL),
(235, '8MONTHS', '', '0000-00-00 00:00:00', NULL, NULL),
(236, 'ST0NE @ PAIN', '', '0000-00-00 00:00:00', NULL, NULL),
(237, 'BARTHOLIN  ABSCESS', '', '0000-00-00 00:00:00', NULL, NULL),
(238, 'MYOMECTOMY @ HYSTECTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(239, 'CERVICAL BIOPSY', '', '0000-00-00 00:00:00', NULL, NULL),
(240, 'LAP APPENDIX', '', '0000-00-00 00:00:00', NULL, NULL),
(241, 'DERMOID CYST LAP SURGERY', '', '0000-00-00 00:00:00', NULL, NULL),
(242, 'LAPRACTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(243, 'LS&OV.CYST', '', '0000-00-00 00:00:00', NULL, NULL),
(244, 'STRICH', '', '0000-00-00 00:00:00', NULL, NULL),
(245, 'ECTOBIC PREGENCY', '', '0000-00-00 00:00:00', NULL, NULL),
(246, 'VAULT PROLAPSE', '', '0000-00-00 00:00:00', NULL, NULL),
(247, 'AMBLICAL HERNIA', '', '0000-00-00 00:00:00', NULL, NULL),
(248, 'HYSTERECTOMY @ HERNIA', '', '0000-00-00 00:00:00', NULL, NULL),
(249, 'TERNINATION', '', '0000-00-00 00:00:00', NULL, NULL),
(250, 'LAP HYSTRECTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(251, 'CHOLECYSTECTOMY @ HYSTECTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(252, 'BEREAST LUMP', '', '0000-00-00 00:00:00', NULL, NULL),
(253, 'UNMARRIED', '', '0000-00-00 00:00:00', NULL, NULL),
(254, 'VAG HYSTRECTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(255, 'MIERINA', '', '0000-00-00 00:00:00', NULL, NULL),
(256, 'PILONIDAL SINUS', '', '0000-00-00 00:00:00', NULL, NULL),
(257, 'DERMINATION', '', '0000-00-00 00:00:00', NULL, NULL),
(258, 'FRACTURE', '', '0000-00-00 00:00:00', NULL, NULL),
(259, 'ABORTION', '', '0000-00-00 00:00:00', NULL, NULL),
(260, 'LAMP BREST', '', '0000-00-00 00:00:00', NULL, NULL),
(261, 'CX STICH', '', '0000-00-00 00:00:00', NULL, NULL),
(262, 'DROWES', '', '0000-00-00 00:00:00', NULL, NULL),
(263, 'DEROWES', '', '0000-00-00 00:00:00', NULL, NULL),
(264, 'PALIPTATION', '', '0000-00-00 00:00:00', NULL, NULL),
(265, 'STRONE', '', '0000-00-00 00:00:00', NULL, NULL),
(266, 'COUTH', '', '0000-00-00 00:00:00', NULL, NULL),
(267, 'HEADACHE', '', '0000-00-00 00:00:00', NULL, NULL),
(268, 'IMC', '', '0000-00-00 00:00:00', NULL, NULL),
(269, ' 2 MONTH AP PAIN', '', '0000-00-00 00:00:00', NULL, NULL),
(270, 'GS', '', '0000-00-00 00:00:00', NULL, NULL),
(271, 'COUGH', '', '0000-00-00 00:00:00', NULL, NULL),
(272, 'PURS', '', '0000-00-00 00:00:00', NULL, NULL),
(273, 'ADENOMYOSIS', '', '0000-00-00 00:00:00', NULL, NULL),
(274, 'IV FLUIDS', '', '0000-00-00 00:00:00', NULL, NULL),
(275, 'WEEKNESS', '', '0000-00-00 00:00:00', NULL, NULL),
(276, 'CUT REMOVAL', '', '0000-00-00 00:00:00', NULL, NULL),
(277, 'IBD', '', '0000-00-00 00:00:00', NULL, NULL),
(278, ' BREAST CASE', '', '0000-00-00 00:00:00', NULL, NULL),
(279, 'LOW SUGAR', '', '0000-00-00 00:00:00', NULL, NULL),
(280, 'HISTRO LAP&00PHERACTOMY', '', '0000-00-00 00:00:00', NULL, NULL),
(281, 'FIBROID CYST', '', '0000-00-00 00:00:00', NULL, NULL),
(282, 'GAUNDICE', '', '0000-00-00 00:00:00', NULL, NULL),
(283, 'BREAST CASE', '', '0000-00-00 00:00:00', NULL, NULL),
(284, 'HYSTRO LAP', '', '0000-00-00 00:00:00', NULL, NULL),
(285, 'HYSTERECTOMY DON', '', '0000-00-00 00:00:00', NULL, NULL),
(286, 'HAEMOTHREAPY', '', '0000-00-00 00:00:00', NULL, NULL),
(287, 'STERLATION', '', '0000-00-00 00:00:00', NULL, NULL),
(288, 'LOOSE MOTION.', '', '0000-00-00 00:00:00', NULL, NULL),
(289, 'B.P ', '', '0000-00-00 00:00:00', NULL, NULL),
(290, 'NEW BORN', '', '0000-00-00 00:00:00', NULL, NULL),
(291, 'VAG HYSTRECTOMY\\', '', '0000-00-00 00:00:00', NULL, NULL),
(292, 'LOOSE STOOLS', '', '0000-00-00 00:00:00', NULL, NULL),
(293, 'DNC', '', '0000-00-00 00:00:00', NULL, NULL),
(294, 'R.T.A', '', '0000-00-00 00:00:00', NULL, NULL),
(295, 'ANAEMIA', '', '0000-00-00 00:00:00', NULL, NULL),
(296, 'FEVER.', '', '0000-00-00 00:00:00', NULL, NULL),
(297, 'LAG PAIN', '', '0000-00-00 00:00:00', NULL, NULL),
(298, 'VOMITING.', '', '0000-00-00 00:00:00', NULL, NULL),
(299, 'OPSARVATION', '', '0000-00-00 00:00:00', NULL, NULL),
(300, 'test 123`', 'user', '2020-06-24 19:45:58', NULL, NULL),
(301, 'abc 12345', 'user', '2020-06-24 19:56:34', 0, '2020-06-24 19:58:37');

-- --------------------------------------------------------

--
-- Table structure for table `m_category`
--

CREATE TABLE IF NOT EXISTS `m_category` (
  `category_id` int(5) NOT NULL AUTO_INCREMENT,
  `category_name` varchar(100) NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL,
  `updated_by` int(100) DEFAULT NULL,
  `updated_on` datetime DEFAULT NULL,
  PRIMARY KEY (`category_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `m_category`
--

INSERT INTO `m_category` (`category_id`, `category_name`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, 'CATEGORY1', 'user', '2020-06-25 21:56:23', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `m_customer`
--

CREATE TABLE IF NOT EXISTS `m_customer` (
  `customer_id` int(5) NOT NULL,
  `name` varchar(100) NOT NULL,
  `address` varchar(250) NOT NULL,
  `mobile_no` varchar(15) NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL,
  `updated_by` int(100) DEFAULT NULL,
  `updated_on` datetime DEFAULT NULL,
  PRIMARY KEY (`customer_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `m_customer`
--

INSERT INTO `m_customer` (`customer_id`, `name`, `address`, `mobile_no`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, 'cash customer', 'test123', '909090', 'user', '2020-06-19 12:26:23', 0, '2020-06-19 12:27:54');

-- --------------------------------------------------------

--
-- Table structure for table `m_doctor`
--

CREATE TABLE IF NOT EXISTS `m_doctor` (
  `doctor_id` int(3) NOT NULL AUTO_INCREMENT,
  `doctor_name` varchar(50) NOT NULL,
  `specialist` varchar(10) NOT NULL,
  `address` varchar(200) NOT NULL,
  `mobileno` varchar(10) NOT NULL,
  PRIMARY KEY (`doctor_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `m_ecg_xray_test_fees`
--

CREATE TABLE IF NOT EXISTS `m_ecg_xray_test_fees` (
  `ecg_xray_test_fees_id` int(4) NOT NULL AUTO_INCREMENT,
  `test_name` varchar(20) NOT NULL,
  `test_group_name` varchar(200) NOT NULL,
  `amount` double(10,2) NOT NULL,
  `test_description` varchar(250) NOT NULL,
  PRIMARY KEY (`ecg_xray_test_fees_id`),
  KEY `testtypeno` (`ecg_xray_test_fees_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=63 ;

--
-- Dumping data for table `m_ecg_xray_test_fees`
--

INSERT INTO `m_ecg_xray_test_fees` (`ecg_xray_test_fees_id`, `test_name`, `test_group_name`, `amount`, `test_description`) VALUES
(1, 'ECG', 'ECG', 150.00, 'NONE'),
(2, 'ABDOMEN AP', 'XRAY', 200.00, '15*12'),
(3, 'ABDOMEN AP WARMER', 'XRAY', 100.00, '12*10'),
(4, 'ABDOMEN ERRECT', 'XRAY', 200.00, '15*12'),
(5, 'ANKLE JOINT AP', 'XRAY', 130.00, '12*10'),
(6, 'ANKLE JOINT AP LAT', 'XRAY', 200.00, '12*10'),
(7, 'BARIUM ENEMA ', 'XRAY', 130.00, '15*12'),
(8, 'BARIUM MEAL', 'XRAY', 130.00, '15*12'),
(9, 'C1C2 JOINT AP', 'XRAY', 130.00, '15*12'),
(10, 'CALCANEUS-DIRECT', 'XRAY', 130.00, '12*10'),
(11, 'CERVICAL SPINE AP', 'XRAY', 130.00, '12*10'),
(12, 'CERVICAL SPINE AP .L', 'XRAY', 300.00, '12*10'),
(13, 'CHEST & KNEE AP (WAR', 'XRAY', 100.00, '12*10'),
(14, 'CHEST  (P)', 'XRAY', 130.00, '12*10'),
(15, 'CHEST (WARMER)', 'XRAY', 100.00, '12*10'),
(16, 'CHEST AP', 'XRAY', 200.00, '15*12'),
(17, 'CHEST PA', 'XRAY', 200.00, '15*12'),
(18, 'CHEST PA .LAT', 'XRAY', 300.00, '15*12'),
(19, 'CLAVICLE.AP', 'XRAY', 130.00, '15*12'),
(20, 'ELBOW JOINT AP', 'XRAY', 130.00, '12*10'),
(21, 'ELBOW JOINT AP .LAT', 'XRAY', 130.00, '12*10'),
(22, 'FEMUR AP', 'XRAY', 130.00, '12*10'),
(23, 'FEMUR AP, LAT', 'XRAY', 130.00, '12*10'),
(24, 'FOOT AP ', 'XRAY', 130.00, '12*10'),
(25, 'FOOT AP LAT', 'XRAY', 130.00, '12*10'),
(26, 'FOOT AP OBLIQUE', 'XRAY', 200.00, '12*10'),
(27, 'FOREARM AP', 'XRAY', 130.00, '12*10'),
(28, 'FOREARM AP ,LAT', 'XRAY', 130.00, '12*10'),
(29, 'HAND AP', 'XRAY', 130.00, '12*10'),
(30, 'HAND AP ,LAT', 'XRAY', 130.00, '12*10'),
(31, 'HAND ,AP ,OBLIQUE ', 'XRAY', 130.00, '12*10'),
(32, 'HIP AP', 'XRAY', 130.00, '15*12'),
(33, 'HIP AP , LAT', 'XRAY', 300.00, '15*12'),
(34, 'HSG ', 'XRAY', 1000.00, '12*10'),
(35, 'HUMEROUS AP ', 'XRAY', 130.00, '12*10'),
(36, 'HUMEROUS AP  ,LAT', 'XRAY', 130.00, '12*10'),
(37, 'INVERTOGRAM ', 'XRAY', 130.00, '12*10'),
(38, 'IVP', 'XRAY', 130.00, '15*12'),
(39, 'KNEE JOINT AP , LAT', 'XRAY', 200.00, '15*12'),
(40, 'KNEE JOINT AP ', 'XRAY', 130.00, '12*10'),
(41, 'KUB', 'XRAY', 200.00, '15*12'),
(42, 'LS.SPINE ,AP,LAT', 'XRAY', 300.00, '15*12'),
(43, 'LOWER LEG AP ,LAT', 'XRAY', 200.00, '15*12'),
(44, 'LOWER LEG AP ', 'XRAY', 130.00, '12*10'),
(45, 'PATELLA SKYLINE VIEW', 'XRAY', 130.00, '12*10'),
(46, 'PELVIS AP ,', 'XRAY', 200.00, '15*12'),
(47, 'PELVIS AP, LAT', 'XRAY', 300.00, '15*12'),
(48, 'PNS', 'XRAY', 200.00, '12*10'),
(49, 'SACROM C COCCYX AP', 'XRAY', 130.00, '15*12'),
(50, 'SACROM C COCCYX AP  ', 'XRAY', 230.00, '15*12'),
(51, 'SCAPOLLA , PA', 'XRAY', 130.00, '12*10'),
(52, 'SHOULDER AP ', 'XRAY', 130.00, '12*10'),
(53, 'SKULL  AP', 'XRAY', 130.00, '12*10'),
(54, 'SKULL  AP  ,LAT', 'XRAY', 300.00, '12*10'),
(55, 'STANDING KNEE AP ', 'XRAY', 130.00, '12*10'),
(56, 'STANDING KNEE AP ,LA', 'XRAY', 130.00, '15*12'),
(57, 'STERNUM AP ', 'XRAY', 130.00, '15*12'),
(58, 'STERNUM AP LAT', 'XRAY', 230.00, '15*12'),
(59, 'THORACIC SPINE AP', 'XRAY', 130.00, '15*12'),
(60, 'THORACIC SPINE AP ,L', 'XRAY', 300.00, '15*12'),
(61, 'WRIST AP', 'XRAY', 130.00, '12*10'),
(62, 'WRIST AP ,LAT', 'XRAY', 130.00, '12*10');

-- --------------------------------------------------------

--
-- Table structure for table `m_group`
--

CREATE TABLE IF NOT EXISTS `m_group` (
  `group_id` int(5) NOT NULL AUTO_INCREMENT,
  `category_id` int(5) NOT NULL,
  `group_name` varchar(100) NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL,
  `updated_by` int(100) DEFAULT NULL,
  `updated_on` datetime DEFAULT NULL,
  PRIMARY KEY (`group_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `m_ip_fees`
--

CREATE TABLE IF NOT EXISTS `m_ip_fees` (
  `ip_fees_id` int(6) NOT NULL,
  `ip_fees_name` varchar(200) NOT NULL,
  `amount` double(10,2) NOT NULL,
  PRIMARY KEY (`ip_fees_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `m_ip_fees`
--

INSERT INTO `m_ip_fees` (`ip_fees_id`, `ip_fees_name`, `amount`) VALUES
(1, 'Monitor Charges', 600.00),
(2, 'Theatre Charges', 1500.00),
(3, 'Maintanence Charges', 200.00),
(4, 'Duty Nurse Charges', 150.00),
(5, 'ICU', 4000.00),
(6, 'Cath Lab', 3000.00),
(7, 'New Born', 2500.00),
(8, 'Labour Ward', 2400.00);

-- --------------------------------------------------------

--
-- Table structure for table `m_lab_test_fees`
--

CREATE TABLE IF NOT EXISTS `m_lab_test_fees` (
  `lab_test_fees_id` int(3) NOT NULL AUTO_INCREMENT,
  `test_name` varchar(100) NOT NULL,
  `test_description` varchar(500) NOT NULL,
  `amount` double(10,2) NOT NULL,
  PRIMARY KEY (`lab_test_fees_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `m_lab_test_fees`
--

INSERT INTO `m_lab_test_fees` (`lab_test_fees_id`, `test_name`, `test_description`, `amount`) VALUES
(1, 'glucose test', 'glu test descrip', 100.00),
(2, 'bp', 'bp test123', 200.00),
(3, 'Diabetic Profile', 'Diabetic test description', 1000.00),
(4, 'CBC Test', 'cbc test description', 400.00),
(5, 'Test123', 'Desc123', 1000.00),
(6, 'asdd', 'asds', 23.00),
(7, 'Lab Test 123', 'Lab Test 123 DESCRIPTION', 1000.00);

-- --------------------------------------------------------

--
-- Table structure for table `m_opening_stock`
--

CREATE TABLE IF NOT EXISTS `m_opening_stock` (
  `opening_stock_id` int(5) NOT NULL AUTO_INCREMENT,
  `product_id` int(5) NOT NULL,
  `qty` int(6) NOT NULL,
  `mrp` double(10,2) NOT NULL,
  `batch` varchar(50) NOT NULL,
  `expiry_date` date NOT NULL,
  PRIMARY KEY (`product_id`,`batch`),
  UNIQUE KEY `opening_stock_id` (`opening_stock_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `m_patient_registration`
--

CREATE TABLE IF NOT EXISTS `m_patient_registration` (
  `patient_id` int(6) NOT NULL AUTO_INCREMENT,
  `uhid` varchar(20) DEFAULT NULL,
  `patient_name` varchar(100) DEFAULT NULL,
  `age` int(3) DEFAULT NULL,
  `dmy` varchar(3) DEFAULT NULL,
  `gender` varchar(10) DEFAULT NULL,
  `date_of_birth` date NOT NULL,
  `next_of_kin` varchar(100) DEFAULT NULL,
  `patient_address` varchar(80) DEFAULT NULL,
  `patient_mobileno` varchar(16) DEFAULT NULL,
  `visiting_id_no` varchar(50) DEFAULT NULL,
  `consultant` varchar(50) DEFAULT NULL,
  `date_of_reg` varchar(30) DEFAULT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL,
  `updated_by` varchar(100) DEFAULT NULL,
  `updated_on` datetime DEFAULT NULL,
  PRIMARY KEY (`patient_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `m_product`
--

CREATE TABLE IF NOT EXISTS `m_product` (
  `product_id` int(5) NOT NULL AUTO_INCREMENT,
  `category_id` int(3) NOT NULL,
  `group_id` int(3) NOT NULL,
  `product_name` varchar(100) NOT NULL,
  `product_name_tamil` longtext CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `product_code` varchar(50) NOT NULL,
  `hsn_code` varchar(50) NOT NULL,
  `gst` int(5) NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL,
  `updated_by` varchar(100) DEFAULT NULL,
  `updated_on` datetime DEFAULT NULL,
  PRIMARY KEY (`product_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `m_room`
--

CREATE TABLE IF NOT EXISTS `m_room` (
  `room_id` int(3) NOT NULL AUTO_INCREMENT,
  `room_name` varchar(50) NOT NULL,
  `amount` double(10,2) NOT NULL,
  `status` varchar(10) NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL,
  `updated_by` int(100) DEFAULT NULL,
  `updated_on` datetime DEFAULT NULL,
  PRIMARY KEY (`room_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=94 ;

--
-- Dumping data for table `m_room`
--

INSERT INTO `m_room` (`room_id`, `room_name`, `amount`, `status`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, '201A', 200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(2, '201B', 200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(3, '202A', 200.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(4, '202B', 200.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(5, '203A', 200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(6, '203B', 200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(7, '204A', 200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(8, '204B', 200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(9, '205A', 200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(10, '205B', 200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(11, '206A', 200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(12, '206B', 200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(13, '207A', 200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(14, '207B', 200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(15, '208A', 200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(16, '210A', 200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(17, '210B', 200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(18, '211A', 200.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(19, '211B', 200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(20, '212A', 200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(21, '212B', 200.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(22, '213A', 200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(23, '213B', 200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(24, '214A', 200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(25, '101', 250.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(26, '102', 250.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(27, '103', 250.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(28, '104', 250.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(29, '105', 250.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(30, '106', 250.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(31, '109', 250.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(32, '111', 250.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(33, '112', 250.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(34, '121', 250.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(35, '122', 250.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(36, '123', 250.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(37, '124', 250.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(38, '125', 250.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(39, '126', 250.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(40, '21', 250.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(41, '22', 250.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(42, '23', 250.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(43, '24', 250.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(44, '25', 250.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(45, '26', 250.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(46, '1', 300.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(47, '2', 300.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(48, '3', 300.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(49, '5', 300.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(50, '6', 300.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(51, '7', 300.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(52, '8', 300.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(53, '10', 300.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(54, '11', 300.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(55, '107', 400.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(56, '108', 400.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(57, '301', 600.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(58, '302', 600.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(59, '303', 600.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(60, '304', 600.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(61, '305', 600.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(62, '306', 600.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(63, '307', 600.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(64, '308', 600.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(65, '309', 600.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(66, '310', 600.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(67, '311', 600.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(68, '313', 600.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(69, '314', 600.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(70, '127', 400.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(71, '401', 600.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(72, '402', 600.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(73, '403', 600.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(74, '404', 600.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(75, '405', 600.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(76, '406', 600.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(77, '407', 600.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(78, '408', 600.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(79, '409', 600.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(80, '410', 600.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(81, '411', 1200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(82, '412', 1200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(83, '9', 600.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(84, '312', 1200.00, 'U', '', '0000-00-00 00:00:00', NULL, NULL),
(85, '315', 1200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(86, '316', 1200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(87, '128', 1200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(88, '413', 1200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(89, '414', 1200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(90, '110', 1200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(91, '208B', 200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(92, '214B', 200.00, 'A', '', '0000-00-00 00:00:00', NULL, NULL),
(93, 'abc1234567', 300.00, '', 'user', '2020-06-24 20:10:36', 0, '2020-06-24 20:13:36');

-- --------------------------------------------------------

--
-- Table structure for table `m_scan_test`
--

CREATE TABLE IF NOT EXISTS `m_scan_test` (
  `scan_test_id` int(3) NOT NULL AUTO_INCREMENT,
  `test_name` varchar(100) NOT NULL,
  `test_description` varchar(500) NOT NULL,
  PRIMARY KEY (`scan_test_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=21 ;

--
-- Dumping data for table `m_scan_test`
--

INSERT INTO `m_scan_test` (`scan_test_id`, `test_name`, `test_description`) VALUES
(1, 'ANC Scan', ''),
(2, 'Abdomen & Pelvis Scan', ''),
(3, 'Cyst Size', ''),
(4, 'Pelvic Scan', ''),
(5, '4D ANC Scan', ''),
(6, 'BREAST SCAN', ''),
(7, 'Doppler One Leg', ''),
(8, 'Thyroid Scan', ''),
(9, 'Newborn Scan', ''),
(10, 'FS', ''),
(11, 'GA & FH', ''),
(12, 'Liquor & FH', ''),
(13, 'SSG', ''),
(14, 'ANC Doppler', ''),
(15, 'Scrotal SCan', ''),
(16, 'ANC TWINS Scan', ''),
(17, 'ANAMOLY USG', ''),
(18, 'Test', ''),
(19, 'Echo', ''),
(20, 'Doppler Both Legs', '');

-- --------------------------------------------------------

--
-- Table structure for table `m_scan_test_fees`
--

CREATE TABLE IF NOT EXISTS `m_scan_test_fees` (
  `scan_test_fees_id` int(5) NOT NULL AUTO_INCREMENT,
  `scan_test_id` int(4) NOT NULL,
  `doctor_id` int(3) NOT NULL,
  `fees` double(10,2) NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL,
  `updated_by` varchar(100) DEFAULT NULL,
  `updated_on` datetime DEFAULT NULL,
  PRIMARY KEY (`scan_test_fees_id`),
  UNIQUE KEY `test_id` (`scan_test_id`,`doctor_id`),
  UNIQUE KEY `test_doctor_unique_index` (`scan_test_id`,`doctor_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `m_scan_test_fees`
--

INSERT INTO `m_scan_test_fees` (`scan_test_fees_id`, `scan_test_id`, `doctor_id`, `fees`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, 1, 1, 100.00, '', '0001-01-01 00:00:00', NULL, NULL),
(2, 1, 2, 200.00, '', '0001-01-01 00:00:00', NULL, NULL),
(3, 2, 1, 300.00, '', '0001-01-01 00:00:00', NULL, NULL),
(5, 2, 2, 390.00, '', '0001-01-01 00:00:00', NULL, NULL),
(6, 2, 3, 270.00, '', '0001-01-01 00:00:00', NULL, NULL),
(7, 18, 2, 100.00, '', '0000-00-00 00:00:00', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `m_supplier`
--

CREATE TABLE IF NOT EXISTS `m_supplier` (
  `supplier_id` int(5) NOT NULL,
  `name` varchar(100) NOT NULL,
  `address` varchar(250) NOT NULL,
  `mobile_no` varchar(15) NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL,
  `updated_by` int(100) DEFAULT NULL,
  `updated_on` datetime DEFAULT NULL,
  PRIMARY KEY (`supplier_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `m_unit`
--

CREATE TABLE IF NOT EXISTS `m_unit` (
  `unitno` int(5) NOT NULL,
  `unitname` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `m_unit`
--

INSERT INTO `m_unit` (`unitno`, `unitname`) VALUES
(1, 'Pcs'),
(2, 'Stripes');

-- --------------------------------------------------------

--
-- Table structure for table `m_user`
--

CREATE TABLE IF NOT EXISTS `m_user` (
  `user_id` int(3) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `email_id` varchar(100) NOT NULL,
  `mobile_no` int(11) NOT NULL,
  `username` varchar(25) NOT NULL,
  `password` varchar(100) NOT NULL,
  `department_id` int(3) NOT NULL,
  `role` varchar(25) NOT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `m_user`
--

INSERT INTO `m_user` (`user_id`, `name`, `email_id`, `mobile_no`, `username`, `password`, `department_id`, `role`) VALUES
(1, 'Dr.Raja', 'dr.raja@gmail.com', 2147483647, 'admin', 'admin', 1, 'A'),
(2, 'user', 'user', 9658995, 'user', 'user', 2, 'U');

-- --------------------------------------------------------

--
-- Table structure for table `outpatientdetails`
--

CREATE TABLE IF NOT EXISTS `outpatientdetails` (
  `txno` bigint(8) NOT NULL,
  `tokenno` int(3) NOT NULL,
  `date` date NOT NULL,
  `noontype` varchar(20) NOT NULL,
  `patient_id` int(10) NOT NULL,
  `uhid` varchar(20) NOT NULL,
  `casetype` varchar(15) NOT NULL,
  `casetype1` varchar(100) NOT NULL,
  `doctor_id` int(10) NOT NULL,
  `fees` int(5) NOT NULL,
  `payment_status` varchar(10) NOT NULL,
  `op_status` varchar(20) NOT NULL,
  `createdason` datetime NOT NULL,
  `updatedason` datetime NOT NULL,
  PRIMARY KEY (`txno`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `payment`
--

CREATE TABLE IF NOT EXISTS `payment` (
  `payment_id` int(5) NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `group_id` int(5) NOT NULL,
  `amount` double(10,2) NOT NULL,
  `remarks` varchar(200) NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL,
  `updated_by` int(100) DEFAULT NULL,
  `updated_on` datetime DEFAULT NULL,
  PRIMARY KEY (`payment_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `payment`
--

INSERT INTO `payment` (`payment_id`, `date`, `group_id`, `amount`, `remarks`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, '2020-07-02', 4, 1250.00, '-', 'user', '2020-07-02 15:52:29', 0, '2020-07-02 15:52:38'),
(2, '2020-07-02', 2, 1200.00, '-', 'user', '2020-07-02 17:02:32', NULL, NULL),
(3, '2020-07-02', 1, 158.00, 'KLSFD', 'user', '2020-07-02 17:04:22', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `purchase`
--

CREATE TABLE IF NOT EXISTS `purchase` (
  `purchase_id` int(6) NOT NULL,
  `date` date NOT NULL,
  `supplier_id` int(4) NOT NULL,
  `bill_invoice_no` varchar(15) NOT NULL,
  `freight` double(10,2) NOT NULL,
  `others` double(10,2) NOT NULL,
  `less_amount` double(10,2) NOT NULL,
  `total_amount` double(10,2) NOT NULL,
  PRIMARY KEY (`purchase_id`),
  KEY `supplierno` (`supplier_id`),
  KEY `supplierno_2` (`supplier_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `purchase_details`
--

CREATE TABLE IF NOT EXISTS `purchase_details` (
  `purchase_id` int(6) NOT NULL,
  `txno` int(3) NOT NULL,
  `product_id` int(6) NOT NULL,
  `qty` int(5) NOT NULL,
  `batch_id` varchar(50) NOT NULL,
  `expiry_date` date NOT NULL,
  `mrp` double(10,2) NOT NULL,
  `purchase_rate` double(10,2) NOT NULL,
  `discount` double(10,2) NOT NULL,
  `gst` double(10,2) NOT NULL,
  `total` double(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `purchase_return`
--

CREATE TABLE IF NOT EXISTS `purchase_return` (
  `purchase_return_id` int(5) NOT NULL AUTO_INCREMENT,
  `purchase_id` int(5) NOT NULL,
  `date` date NOT NULL,
  `product_id` int(5) NOT NULL,
  `qty` double(10,2) NOT NULL,
  `mrp` double(10,2) NOT NULL,
  `batch_id` varchar(25) NOT NULL,
  `expiry_date` varchar(50) NOT NULL,
  `reason` varchar(250) NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL,
  `updated_by` int(100) DEFAULT NULL,
  `updated_on` datetime DEFAULT NULL,
  PRIMARY KEY (`purchase_return_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `receipt`
--

CREATE TABLE IF NOT EXISTS `receipt` (
  `receipt_id` int(5) NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `customer_id` int(5) NOT NULL,
  `amount` double(10,2) NOT NULL,
  `remarks` varchar(200) NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL,
  `updated_by` int(100) DEFAULT NULL,
  `updated_on` datetime DEFAULT NULL,
  PRIMARY KEY (`receipt_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `receipt`
--

INSERT INTO `receipt` (`receipt_id`, `date`, `customer_id`, `amount`, `remarks`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, '2020-07-01', 1, 1000.00, '-', 'user', '2020-07-02 08:07:57', NULL, NULL),
(2, '2020-07-02', 2732, 1250.00, 'test', 'user', '2020-07-02 08:28:17', NULL, NULL),
(3, '2020-07-01', 3507, 2000.00, 'dfg', 'user', '2020-07-02 15:12:43', NULL, NULL),
(4, '2020-07-03', 12228, 5000.00, 'Inpatient pending  bill', 'user', '2020-07-03 06:47:36', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE IF NOT EXISTS `sales` (
  `sales_id` int(5) NOT NULL,
  `date` date NOT NULL,
  `patient_id` int(5) NOT NULL,
  `less_amount` double(10,2) NOT NULL,
  `service_amount` varchar(100) NOT NULL,
  `total_amount` double(10,2) NOT NULL,
  `despatch` varchar(100) NOT NULL,
  `destination` varchar(100) NOT NULL,
  `mode_of_payment` varchar(50) NOT NULL,
  `terms_of_delivery` varchar(200) NOT NULL,
  `vehicle_no` varchar(100) NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL,
  `updated_by` varchar(100) DEFAULT NULL,
  `updated_on` datetime DEFAULT NULL,
  PRIMARY KEY (`sales_id`),
  KEY `customerno` (`patient_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `sales_details`
--

CREATE TABLE IF NOT EXISTS `sales_details` (
  `sales_id` int(5) NOT NULL,
  `txno` int(3) NOT NULL,
  `product_id` int(5) NOT NULL,
  `batch_id` varchar(100) NOT NULL,
  `expiry_date` date NOT NULL,
  `qty` int(6) NOT NULL,
  `unit_rate` double(10,2) NOT NULL,
  `amount` double(10,2) NOT NULL,
  `gst` double(5,2) NOT NULL,
  `discount_percentage` double(10,2) NOT NULL,
  `unit_mrp` double(10,2) NOT NULL,
  PRIMARY KEY (`sales_id`,`txno`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `sales_return`
--

CREATE TABLE IF NOT EXISTS `sales_return` (
  `sales_return_id` int(5) NOT NULL AUTO_INCREMENT,
  `sales_id` int(5) NOT NULL,
  `date` date NOT NULL,
  `product_id` int(5) NOT NULL,
  `qty` double(10,2) NOT NULL,
  `mrp` double(10,2) NOT NULL,
  `batch_id` varchar(25) NOT NULL,
  `expiry_date` varchar(50) NOT NULL,
  `reason` varchar(250) NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL,
  `updated_by` int(100) DEFAULT NULL,
  `updated_on` datetime DEFAULT NULL,
  PRIMARY KEY (`sales_return_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `setup_companyinfo`
--

CREATE TABLE IF NOT EXISTS `setup_companyinfo` (
  `companyno` int(2) NOT NULL AUTO_INCREMENT,
  `companytitle` varchar(100) NOT NULL,
  `companyaddress1` varchar(100) NOT NULL,
  `companyaddress2` varchar(100) NOT NULL,
  `companyaddress3` varchar(100) NOT NULL,
  `companycontactno` varchar(100) NOT NULL,
  `gstinno` varchar(50) NOT NULL,
  PRIMARY KEY (`companyno`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `setup_companyinfo`
--

INSERT INTO `setup_companyinfo` (`companyno`, `companytitle`, `companyaddress1`, `companyaddress2`, `companyaddress3`, `companycontactno`, `gstinno`) VALUES
(1, 'SUPER MARKET ', 'No-1 Middle Street, Melapalayam   ', '-            ', '9090909090               ', '                ', '                ');

-- --------------------------------------------------------

--
-- Table structure for table `stock`
--

CREATE TABLE IF NOT EXISTS `stock` (
  `stock_id` int(5) NOT NULL AUTO_INCREMENT,
  `product_id` int(5) NOT NULL,
  `qty` int(5) NOT NULL,
  `mrp` double(10,2) NOT NULL,
  `batch_id` varchar(50) NOT NULL,
  `expiry_date` date NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL,
  `updated_by` int(100) DEFAULT NULL,
  `updated_on` datetime DEFAULT NULL,
  PRIMARY KEY (`product_id`,`mrp`,`batch_id`),
  UNIQUE KEY `stock_id` (`stock_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `stock_history`
--

CREATE TABLE IF NOT EXISTS `stock_history` (
  `product_id` int(5) NOT NULL,
  `old_qty` int(5) NOT NULL,
  `change_qty` int(5) NOT NULL,
  `current_qty` int(5) NOT NULL,
  `mrp` double(10,2) NOT NULL,
  `batch_id` varchar(50) NOT NULL,
  `expiry_date` varchar(50) NOT NULL,
  `reason` varchar(100) NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
