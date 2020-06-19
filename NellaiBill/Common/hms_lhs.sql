-- phpMyAdmin SQL Dump
-- version 4.0.4.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jun 19, 2020 at 04:28 PM
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
-- Table structure for table `accounts_payment`
--

CREATE TABLE IF NOT EXISTS `accounts_payment` (
  `accounts_payment_id` int(11) NOT NULL AUTO_INCREMENT,
  `accounts_payment_date` date NOT NULL,
  `accounts_payment_ledger_id` int(5) NOT NULL,
  `accounts_payment_amount` double(10,2) NOT NULL,
  `accounts_payment_remarks` varchar(200) NOT NULL,
  PRIMARY KEY (`accounts_payment_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `accounts_receipt`
--

CREATE TABLE IF NOT EXISTS `accounts_receipt` (
  `accounts_receipt_id` int(11) NOT NULL AUTO_INCREMENT,
  `accounts_receipt_date` date NOT NULL,
  `accounts_receipt_ledger_id` int(5) NOT NULL,
  `accounts_receipt_amount` double(10,2) NOT NULL,
  `accounts_receipt_remarks` varchar(200) NOT NULL,
  PRIMARY KEY (`accounts_receipt_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `account_group`
--

CREATE TABLE IF NOT EXISTS `account_group` (
  `account_group_id` int(11) NOT NULL,
  `account_group_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `account_group`
--

INSERT INTO `account_group` (`account_group_id`, `account_group_name`) VALUES
(1, 'CAPITAL ACCOUNT'),
(2, 'CURRENT ASSETS'),
(3, 'CURRENT LIABILITIES'),
(4, 'PURCHASE ACCOUNTS'),
(5, 'SALES ACCOUNTS'),
(6, 'BRANCH/DIVISIONS'),
(7, 'FIXED ASSETS'),
(8, 'DIRECT EXPENSES'),
(9, 'DIRECT INCOMES'),
(10, 'INDIRECT EXPENSES'),
(11, 'INDIRECT INCOMES'),
(12, 'INVESTMENTS'),
(13, 'LOANS(LIABILITY)'),
(14, 'MISC.EXPENSES(ASSET)'),
(15, 'SUSPENSE ACCOUNT'),
(16, 'CASH-IN-HAND'),
(17, 'DEPOSITS(ASSETS)'),
(18, 'DUTIES & TAXES'),
(19, 'LOANS & ADVANCES (ASSET)'),
(20, 'PROVISIONS'),
(21, 'RETAINED EARNINGS'),
(22, 'SECURED LOANS'),
(23, 'STOCK-IN-HAND'),
(24, 'SUNDRY CREDITORS'),
(25, 'SUNDRY DEBTORS'),
(26, 'UNSECURED LOANS'),
(27, 'BANK ACCOUNTS'),
(28, 'BANK OD ACCOUNTS'),
(29, 'BANK OCC ACCOUNTS');

-- --------------------------------------------------------

--
-- Table structure for table `account_ledger`
--

CREATE TABLE IF NOT EXISTS `account_ledger` (
  `account_ledger_id` int(11) NOT NULL,
  `ledger_name` varchar(100) DEFAULT NULL,
  `ledger_alias_name` varchar(100) NOT NULL,
  `ledger_undergroup_no` int(11) NOT NULL,
  `ledger_address` varchar(250) NOT NULL,
  `ledger_mobile_no` varchar(50) NOT NULL,
  `ledger_unique_no` varchar(50) NOT NULL,
  `credit_limit` double(10,2) NOT NULL,
  `opening_balance` double(10,2) NOT NULL,
  PRIMARY KEY (`account_ledger_id`),
  UNIQUE KEY `ledger_name` (`ledger_name`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `account_ledger`
--

INSERT INTO `account_ledger` (`account_ledger_id`, `ledger_name`, `ledger_alias_name`, `ledger_undergroup_no`, `ledger_address`, `ledger_mobile_no`, `ledger_unique_no`, `credit_limit`, `opening_balance`) VALUES
(1, 'TEST SUPPLIER ', '', 4, '', '', '', 0.00, 0.00),
(2, 'TEST CASH CUSTOMER', '', 5, '', '', '', 0.00, 0.00),
(3, 'arasan agencies', '', 4, 'Tuticorin', '9898989898', '', 0.00, 0.00);

-- --------------------------------------------------------

--
-- Table structure for table `backup`
--

CREATE TABLE IF NOT EXISTS `backup` (
  `id` int(5) NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `backup`
--

INSERT INTO `backup` (`id`, `date`) VALUES
(1, '2020-05-28');

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=53 ;

--
-- Dumping data for table `billing_ecg_xray`
--

INSERT INTO `billing_ecg_xray` (`billing_ecg_xray_id`, `date`, `patient_id`, `test_id`, `doctor_id`, `fees`, `section`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, '2020-06-03', 10041, 1, 2, 150.00, 'LABOURWARD', 'RECEPTION', '2020-06-03 07:46:47', NULL, NULL),
(2, '2020-06-03', 1316, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-03 12:14:43', NULL, NULL),
(3, '2020-06-03', 12067, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-03 12:15:39', NULL, NULL),
(4, '2020-06-03', 9991, 1, 1, 150.00, 'OP', 'RECEPTION', '2020-06-03 12:40:53', NULL, NULL),
(5, '2020-06-03', 12058, 1, 2, 150.00, 'LABOURWARD', 'RECEPTION', '2020-06-03 01:30:52', NULL, NULL),
(6, '2020-06-03', 5454, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-03 01:57:14', NULL, NULL),
(7, '2020-06-03', 5311, 1, 2, 150.00, 'LABOURWARD', 'RECEPTION', '2020-06-03 04:18:19', NULL, NULL),
(8, '2020-06-03', 6998, 1, 2, 150.00, 'LABOURWARD', 'RECEPTION', '2020-06-03 05:02:37', NULL, NULL),
(9, '2020-06-03', 3492, 1, 2, 150.00, 'LABOURWARD', 'RECEPTION', '2020-06-03 06:04:55', NULL, NULL),
(10, '2020-06-04', 10193, 1, 1, 150.00, 'OP', 'RECEPTION', '2020-06-04 10:02:47', NULL, NULL),
(11, '2020-06-04', 10193, 17, 1, 200.00, 'OP', 'RECEPTION', '2020-06-04 10:03:21', NULL, NULL),
(12, '2020-06-04', 12053, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-04 10:41:27', NULL, NULL),
(13, '2020-06-04', 2742, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-04 02:14:07', NULL, NULL),
(14, '2020-06-04', 10184, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-04 02:22:26', NULL, NULL),
(15, '2020-06-04', 6677, 1, 2, 150.00, 'LABOURWARD', 'RECEPTION', '2020-06-04 03:05:10', NULL, NULL),
(16, '2020-06-04', 12096, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-04 03:38:33', NULL, NULL),
(17, '2020-06-05', 5260, 1, 8, 150.00, 'OP', 'RECEPTION', '2020-06-05 12:08:19', NULL, NULL),
(18, '2020-06-05', 5260, 17, 8, 200.00, 'OP', 'RECEPTION', '2020-06-05 12:08:55', NULL, NULL),
(19, '2020-06-05', 12126, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-05 01:17:40', NULL, NULL),
(20, '2020-06-05', 12090, 1, 2, 150.00, 'LABOURWARD', 'RECEPTION', '2020-06-05 06:04:31', NULL, NULL),
(21, '2020-06-05', 12090, 17, 2, 200.00, 'LABOURWARD', 'RECEPTION', '2020-06-05 06:04:55', NULL, NULL),
(22, '2020-06-05', 12124, 1, 2, 150.00, 'LABOURWARD', 'RECEPTION', '2020-06-05 08:21:52', NULL, NULL),
(23, '2020-06-06', 4917, 1, 1, 150.00, 'OP', 'RECEPTION', '2020-06-06 01:42:55', NULL, NULL),
(24, '2020-06-07', 3473, 1, 1, 150.00, 'LABOURWARD', 'RECEPTION', '2020-06-07 10:33:05', NULL, NULL),
(26, '2020-06-07', 7107, 1, 2, 150.00, 'LABOURWARD', 'RECEPTION', '2020-06-07 02:01:44', NULL, NULL),
(27, '2020-06-07', 12010, 1, 2, 150.00, 'LABOURWARD', 'RECEPTION', '2020-06-07 05:25:14', NULL, NULL),
(28, '2020-06-08', 1414, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-08 11:06:18', NULL, NULL),
(29, '2020-06-08', 12164, 1, 1, 150.00, 'OP', 'RECEPTION', '2020-06-08 11:52:29', NULL, NULL),
(30, '2020-06-08', 12163, 1, 1, 150.00, 'OP', 'RECEPTION', '2020-06-08 11:56:12', NULL, NULL),
(31, '2020-06-08', 12162, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-08 12:00:37', NULL, NULL),
(32, '2020-06-08', 9997, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-08 12:25:49', NULL, NULL),
(33, '2020-06-08', 7731, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-08 01:03:16', NULL, NULL),
(34, '2020-06-08', 12170, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-08 01:27:24', NULL, NULL),
(35, '2020-06-08', 7122, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-08 02:26:10', NULL, NULL),
(36, '2020-06-08', 12175, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-08 03:10:47', NULL, NULL),
(37, '2020-06-08', 3980, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-08 04:08:04', NULL, NULL),
(38, '2020-06-10', 12197, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-10 12:04:29', NULL, NULL),
(39, '2020-06-10', 12220, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-10 12:14:24', NULL, NULL),
(40, '2020-06-10', 4900, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-10 12:30:00', NULL, NULL),
(41, '2020-06-10', 10051, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-10 12:50:05', NULL, NULL),
(42, '2020-06-10', 7038, 1, 2, 150.00, 'LABOURWARD', 'RECEPTION', '2020-06-10 02:32:41', NULL, NULL),
(43, '2020-06-10', 3469, 1, 2, 150.00, 'LABOURWARD', 'RECEPTION', '2020-06-10 06:51:48', NULL, NULL),
(44, '2020-06-10', 6980, 1, 2, 150.00, 'LABOURWARD', 'RECEPTION', '2020-06-10 07:09:06', NULL, NULL),
(45, '2020-06-11', 653, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-11 11:09:43', NULL, NULL),
(46, '2020-06-11', 10072, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-11 11:55:18', NULL, NULL),
(47, '2020-06-11', 12260, 1, 1, 150.00, 'OP', 'RECEPTION', '2020-06-11 12:44:47', NULL, NULL),
(48, '2020-06-11', 12260, 17, 1, 200.00, 'OP', 'RECEPTION', '2020-06-11 12:45:52', NULL, NULL),
(49, '2020-06-12', 3528, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-12 11:30:09', NULL, NULL),
(50, '2020-06-12', 4260, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-12 11:42:06', NULL, NULL),
(51, '2020-06-12', 7731, 1, 1, 150.00, 'OP', 'RECEPTION', '2020-06-12 01:02:30', NULL, NULL),
(52, '2020-06-12', 12298, 1, 2, 150.00, 'OP', 'RECEPTION', '2020-06-12 02:06:47', NULL, NULL);

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=12 ;

--
-- Dumping data for table `billing_lab`
--

INSERT INTO `billing_lab` (`lab_id`, `date`, `patient_id`, `doctor_id`, `total_amount`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, '2020-06-05', 1, 1, 100.00, 'TEST', '2020-06-05 22:47:26', NULL, NULL),
(2, '2020-06-05', 1, 3, 300.00, 'TEST', '2020-06-05 23:34:45', NULL, NULL),
(3, '2020-06-05', 1, 3, 300.00, 'TEST', '2020-06-05 23:38:32', NULL, NULL),
(4, '2020-06-06', 12128, 1, 300.00, 'TEST', '2020-06-06 16:58:56', NULL, NULL),
(5, '2020-06-10', 12161, 5, 300.00, 'TEST', '2020-06-10 22:48:16', NULL, NULL),
(6, '2020-06-10', 16, 4, 300.00, 'TEST', '2020-06-10 23:19:06', NULL, NULL),
(7, '2020-06-11', 3479, 3, 1600.00, 'TEST', '2020-06-11 21:07:06', NULL, NULL),
(8, '2020-06-11', 12163, 7, 1400.00, 'TEST', '2020-06-11 21:30:37', NULL, NULL),
(9, '2020-06-11', 6, 3, 1400.00, 'TEST', '2020-06-11 21:34:12', NULL, NULL),
(10, '2020-06-13', 1, 2, 1400.00, 'TEST', '2020-06-13 16:05:52', NULL, NULL),
(11, '2020-06-13', 5, 11, 1200.00, 'TEST', '2020-06-13 17:14:08', NULL, NULL);

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

--
-- Dumping data for table `billing_lab_details`
--

INSERT INTO `billing_lab_details` (`lab_id`, `txno`, `test_id`, `patient_test_details`, `amount`) VALUES
(3, 1, 2, 'bbbb', 200.00),
(3, 2, 1, 'aaa', 100.00),
(4, 1, 1, '', 100.00),
(4, 2, 2, '', 200.00),
(5, 1, 2, '', 200.00),
(5, 2, 1, '', 100.00),
(6, 1, 1, '', 100.00),
(6, 2, 2, '', 200.00),
(7, 1, 3, 'Test 22', 1000.00),
(7, 2, 4, 'Test 33', 400.00),
(7, 3, 2, 'Test12', 200.00),
(8, 1, 3, '1000 diab prof', 1000.00),
(8, 2, 4, '100 count', 400.00),
(9, 1, 3, 'test 100', 1000.00),
(9, 2, 4, '250 count', 400.00),
(10, 1, 3, '100 mg', 1000.00),
(10, 2, 4, '100000 count', 400.00),
(11, 1, 3, 'sdfsdfsdfsdfsdf', 1000.00),
(11, 2, 2, 'dsfsdf', 200.00);

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=13 ;

--
-- Dumping data for table `billing_scan`
--

INSERT INTO `billing_scan` (`scan_id`, `date`, `patient_id`, `doctor_id`, `test_id`, `fees`, `doctor_suggestion`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, '2020-06-03', 1, 1, 1, 100.00, '', 'RECEPTION', '2020-06-03 11:13:24', NULL, NULL),
(2, '2020-06-03', 6, 1, 2, 300.00, '', 'RECEPTION', '2020-06-03 11:15:07', NULL, NULL),
(3, '2020-06-03', 3, 3, 2, 270.00, '', 'RECEPTION', '2020-06-03 11:18:57', NULL, '2020-06-03 11:19:21'),
(4, '2020-06-04', 1, 1, 1, 100.00, '', 'RECEPTION', '2020-06-04 08:31:06', NULL, NULL),
(5, '2020-06-04', 6, 2, 2, 390.00, '', 'RECEPTION', '2020-06-04 08:33:32', NULL, NULL),
(6, '2020-06-04', 6, 2, 1, 200.00, '', 'RECEPTION', '2020-06-04 08:37:05', NULL, NULL),
(7, '2020-06-06', 12128, 1, 1, 100.00, '', 'RECEPTION', '2020-06-06 04:58:11', NULL, NULL),
(8, '2020-06-10', 12161, 1, 1, 100.00, '', 'RECEPTION', '2020-06-10 10:47:15', NULL, NULL),
(9, '2020-06-10', 16, 2, 1, 200.00, '', 'RECEPTION', '2020-06-10 11:18:22', NULL, NULL),
(10, '2020-06-11', 12163, 2, 1, 200.00, '', 'RECEPTION', '2020-06-11 09:29:44', NULL, NULL),
(11, '2020-06-11', 68, 1, 2, 300.00, '', 'RECEPTION', '2020-06-11 09:33:38', NULL, NULL),
(12, '2020-06-13', 1, 2, 1, 200.00, '', 'RECEPTION', '2020-06-13 06:34:54', NULL, NULL);

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `ip_admission`
--

INSERT INTO `ip_admission` (`ipno`, `date`, `patient_id`, `doctor_id`, `case_type_id`, `room_id`, `admitted_by`, `is_paid`, `is_discharged`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, '2020-06-07', 1, 2, 3, 3, 'Saleem', 0, 1, 'user', '0000-00-00 00:00:00', NULL, NULL),
(2, '2020-06-07', 2, 2, 2, 28, 'Raja123', 0, 1, 'user', '2020-06-07 17:46:09', 'user', '2020-06-07 18:11:29'),
(3, '2020-06-10', 12161, 7, 12, 66, 'Mani', 0, 1, 'user', '2020-06-10 22:50:05', NULL, NULL),
(4, '2020-06-10', 13, 2, 1, 85, 'Raja', 0, 1, 'user', '2020-06-10 23:20:49', NULL, NULL),
(5, '2020-06-11', 106, 5, 2, 68, 'Rajender', 0, 1, 'user', '2020-06-11 21:03:58', NULL, NULL),
(6, '2020-06-11', 17, 3, 2, 56, 'Raja', 0, 1, 'user', '2020-06-11 21:35:44', NULL, NULL),
(7, '2020-06-13', 6, 9, 26, 65, 'Haji', 0, 0, 'user', '2020-06-13 16:08:58', NULL, NULL);

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Dumping data for table `ip_advance_payment`
--

INSERT INTO `ip_advance_payment` (`advance_payment_id`, `date`, `ipno`, `amount`) VALUES
(1, '2020-06-10', 1, 10000.00),
(2, '2020-06-10', 2, 5000.00),
(3, '2020-06-10', 2, 3000.00),
(4, '2020-06-10', 3, 12000.00),
(5, '2020-06-10', 4, 5000.00),
(6, '2020-06-11', 5, 5000.00),
(7, '2020-06-11', 6, 2000.00),
(8, '2020-06-13', 7, 1000.00);

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `ip_discharge_entry`
--

INSERT INTO `ip_discharge_entry` (`ip_discharge_entry_id`, `date`, `ipno`, `admission_condition`, `investigation_done`, `treatement_given`, `clinical_course`, `discharge_condition`, `discharge_advice`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, '2020-06-13', 1, 'admi1 aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa aaaaaaaaaaaaaaaaaaaaaaaaa aaaaaaaaaaaaaaaaaaaaaa        aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa a           aaaaaaaaaaaaaaaaaaaa', 'bbbbbbbbbbbbbbbbbbbbbbbbbbbbbb bbbbbbbbbbbbbbbbbbbbbbbbbbbbb bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb bbbbbbbbbbbbbbbbbbinv', 'cccccccccccccccccccc              cccccccccccccccccccccccccccccc                 ccccccccccccccctreat', 'dddddddddddddddddddd clinic', 'eeeeeeeeeeeeee cond dis', 'f         ff f f f f dis adv', 'user', '2020-06-13 10:46:59', 'user', '2020-06-13 14:01:13');

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Dumping data for table `ip_invoice`
--

INSERT INTO `ip_invoice` (`ip_invoice_id`, `date`, `ipno`, `sub_amount`, `advance_amount`, `less_amount`, `total_amount`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, '2020-06-11', 1, 12000.00, 10000.00, 500.00, 1500.00, 'user', '2020-06-11 12:55:19', '', NULL),
(2, '2020-06-11', 2, 9000.00, 8000.00, 200.00, 800.00, 'user', '2020-06-11 14:47:43', '', NULL),
(3, '2020-06-11', 5, 6000.00, 5000.00, 500.00, 500.00, 'user', '2020-06-11 21:05:32', '', NULL),
(4, '2020-06-11', 6, 5200.00, 2000.00, 200.00, 3000.00, 'user', '2020-06-11 21:37:09', '', NULL),
(5, '2020-06-13', 7, 7000.00, 1000.00, 1000.00, 5000.00, 'user', '2020-06-13 16:12:11', '', NULL),
(6, '2020-06-13', 5, 12000.00, 5000.00, 2000.00, 5000.00, 'user', '2020-06-13 17:18:57', '', NULL);

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

--
-- Dumping data for table `ip_invoice_details`
--

INSERT INTO `ip_invoice_details` (`ip_invoice_id`, `txno`, `particulars`, `amount`) VALUES
(1, 1, 'Monitor Charges', 1000.00),
(1, 2, 'Theatre Charges', 2000.00),
(1, 3, 'Maintanence Charges', 2000.00),
(1, 4, 'ICU', 6000.00),
(1, 5, 'New Born', 1000.00),
(2, 1, 'Monitor Charges', 1000.00),
(2, 2, 'ICU', 4800.00),
(2, 3, 'Cath Lab', 3200.00),
(3, 1, 'Monitor Charges', 2000.00),
(3, 2, 'Theatre Charges', 3000.00),
(3, 3, 'Cath Lab', 1000.00),
(4, 1, 'Maintanence Charges', 2000.00),
(4, 2, 'ICU', 3000.00),
(4, 3, 'Duty Nurse Charges', 200.00),
(5, 1, 'Monitor Charges', 1000.00),
(5, 2, 'ICU', 4000.00),
(5, 3, 'Labour Ward', 2000.00),
(6, 1, 'Monitor Charges', 2000.00),
(6, 2, 'Maintanence Charges', 10000.00);

-- --------------------------------------------------------

--
-- Table structure for table `m_case_type`
--

CREATE TABLE IF NOT EXISTS `m_case_type` (
  `case_type_id` int(4) NOT NULL AUTO_INCREMENT,
  `case_type_name` varchar(100) NOT NULL,
  PRIMARY KEY (`case_type_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=300 ;

--
-- Dumping data for table `m_case_type`
--

INSERT INTO `m_case_type` (`case_type_id`, `case_type_name`) VALUES
(1, 'Delivery'),
(2, 'SUGAR'),
(3, 'HYSTERECTOMY'),
(4, 'VARICOCELEY'),
(5, 'FITZ'),
(6, 'NEW   BORN'),
(7, 'ECTOBIC'),
(8, 'BABY CASE'),
(9, '4MONTHS'),
(10, 'LAP CHOLE'),
(11, 'WHEZZING'),
(12, 'FEVER'),
(13, 'OVAREIAN CYST'),
(14, 'BLOOD TRANSFUSSION'),
(15, '6MONTHS'),
(16, 'PIH'),
(17, 'RE-STITCH'),
(18, 'DIAGNOSTIC LAP'),
(19, 'STEND REMOVAL'),
(20, 'SPOTTING'),
(21, 'CX STITCH'),
(22, 'HERNIA'),
(23, 'BILAT.PCOD'),
(24, 'D&C'),
(25, 'LS'),
(26, 'ORTHO'),
(27, '8 MONTH'),
(28, 'BLEEDING'),
(29, 'GENERAL'),
(30, 'CHEMOTHEROPHY'),
(31, 'APPENDIX'),
(32, 'MYOMECTOMY'),
(33, 'BREAST'),
(34, 'END BIOPSY'),
(35, 'DRIP'),
(36, 'PILES'),
(37, 'M.T.P'),
(38, '7MONTHS'),
(39, 'RENAL CALCULUS'),
(40, 'PS'),
(41, 'GIDDINESS'),
(42, 'STOCK'),
(43, 'H LAP'),
(44, 'BEREAST'),
(45, 'PLEEDING'),
(46, '5MONTH'),
(47, 'ABD.PAIN'),
(48, 'DIARIYA'),
(49, 'VOMITING'),
(50, 'BABY WARMER'),
(51, 'HISTROLAB'),
(52, 'IUD'),
(53, '2MOUNTH'),
(54, 'URINE'),
(55, 'POLYPECTOMY'),
(56, 'MTP&LS'),
(57, 'JUANDICE'),
(58, 'D&C LS'),
(59, 'HEMO THERPY'),
(60, 'BREATHING'),
(61, 'VERICOCLE'),
(62, 'STOMACK PAIN'),
(63, 'DRESSING'),
(64, 'STONE'),
(65, 'CX.STICH'),
(66, 'CALCULAS'),
(67, 'L.S'),
(68, 'BP'),
(69, 'ST0NE'),
(70, 'RECONSLATION'),
(71, 'REMOVALENDPOLY'),
(72, 'TERMINATION'),
(73, 'CEVICALSTITCH'),
(74, 'ABSEESS'),
(75, 'VESICULAR  MOLE'),
(76, 'HERNIA&TERMINATION'),
(77, '9  MONTH'),
(78, '9MONTHS &B.P'),
(79, '6MONTHS&BLEEDING'),
(80, 'HIPPALN'),
(81, 'MTP&TAT'),
(82, 'DESTOSCOPY'),
(83, 'FIBROADEMA'),
(84, 'CYSTECTOMY'),
(85, 'SKIN  PROBLEM'),
(86, 'FISTULLA'),
(87, 'PERNIAL ABCESS'),
(88, 'MISSED ABORTION'),
(89, 'CA BLADDER'),
(90, '8 MONTHS'),
(91, 'STRESSING  CONSISTENCY'),
(92, 'CIRCUMCENSCENION'),
(93, '3  MONTH'),
(94, 'MTP LS'),
(95, 'B.P'),
(96, 'CIRCUMSATION'),
(97, 'HYSTEROSCOPIC'),
(98, 'PSYCHATERISM'),
(99, 'LIYPOMA'),
(100, 'SPTUM DISSECTION'),
(101, 'KIDNEY  PROBLEM'),
(102, 'LAP CYST'),
(103, '3MONTHS BLEEDING'),
(104, 'CUT'),
(105, 'CA BREAST'),
(106, 'CUT-RE    ( LAP)'),
(107, 'UMBLICALHERNIA'),
(108, 'TRIP'),
(109, 'THYROID'),
(110, 'LIPOMA'),
(111, 'MTP TAT'),
(112, 'LOOSE MOTION'),
(113, 'VEGINAL WIDING'),
(114, 'CUT REMOVE  TAT'),
(115, 'LAP CYSTECTOMY'),
(116, 'CX. POLIP'),
(117, 'I&D'),
(118, 'CVA'),
(119, 'LAP CHOLECYSTECTOMY'),
(120, 'BREAST MASS'),
(121, 'HYDROCILE'),
(122, 'WOUND HEELING'),
(123, 'GTT'),
(124, 'GDM'),
(125, 'PLONIDAL ABSCESS'),
(126, 'PAIN'),
(127, 'ASCITIES'),
(128, 'IUI'),
(129, 'LAP CHOLEHYSTECTOMY'),
(130, 'ENTRICFEVER'),
(131, 'AMBLICAL HER &  HYST'),
(132, 'TISSUE MASS BLADDER'),
(133, 'CHEST PAIN'),
(134, 'SLING  REMOVAL'),
(135, 'HYDROCEPHALAS'),
(136, 'EAR  SWELLING'),
(137, 'STEM CELL COLLECTION'),
(138, 'BREAST ABCESS'),
(139, 'SAFE  PRAGNENCY'),
(140, 'GLUTEAL SEBACCOUS'),
(141, 'VEG. INF'),
(142, 'VERTIGO'),
(143, 'ST. INF'),
(144, 'DIAGNOSTIC LAP  & CYSTECTOMY'),
(145, 'PERINIAL SWELLING'),
(146, 'N.I.C.U'),
(147, 'LEG WOUND'),
(148, 'GB CALCULUS'),
(149, 'LAP.MYOMECTOMY'),
(150, 'ABD.CYST'),
(151, 'ENDOSCOPY'),
(152, 'TONGE  TIE'),
(153, 'TYPHOID'),
(154, 'VEG.CYST'),
(155, 'C.V.A'),
(156, 'BATHOLIN  CYST'),
(157, 'COLD'),
(158, 'CYSTOCOLE'),
(159, 'CERVICAL CYST'),
(160, 'BREAST LUMP'),
(161, 'LOOSE  STOOLS'),
(162, 'PERINOTEMY'),
(163, 'TAT'),
(164, 'CHOCOLATE CYST'),
(165, 'CX.BIOPSY'),
(166, 'OVAREIAN CYST @ HYST'),
(167, 'LAPROSCOPY / LAPROTOMY'),
(168, 'SWELLING IN BREAST'),
(169, 'STITCH PROBLEM'),
(170, 'CX STITCH  REMOVED'),
(171, 'TESTICULAR BIOPSY'),
(172, 'ENDOMETRIOTIC CYST'),
(173, 'CHOCOLATE CYSTECTOMY'),
(174, 'ENDOMETRIOTIC CYST[LAP CUSTY]'),
(175, 'OVARY MASS'),
(176, 'VIRAL HEPATITIS'),
(177, 'CHOCHOLECYSTECTOMY'),
(178, 'INFECTION'),
(179, 'FISSURE'),
(180, 'LAP CHOLETCYST'),
(181, 'D&C & TAT'),
(182, 'CUT REMOVE LS'),
(183, '3 MONTHS '),
(184, '3  MONTHS'),
(185, 'BIOPSY'),
(186, 'CALCULAS CHOLECYSTITIS'),
(187, 'HYSTERECTOMY & PILES'),
(188, 'HYSTROSCOPY &  POLYP REMOVAL'),
(189, 'BARTHOLIN S ABSCESS'),
(190, 'URETHRAL POLYP'),
(191, 'B.P. CONTROL'),
(192, 'LAP. APPENDISECTOMY'),
(193, 'SEPTAL RESECTION'),
(194, 'PFR'),
(195, 'URINARY INFECTION'),
(196, 'RECANALISATION'),
(197, 'LAP SURGERY'),
(198, 'D&C & GA'),
(199, 'LAP OVAREIAN CYSTECTOMY'),
(200, 'BLOOD TRANSFUSSION @ D&C'),
(201, 'URINE PROBLEM'),
(202, 'DELIVERY OUT SIDEBABY C.T.V'),
(203, 'DIAGNOSTIC LAP & MYOMECTOMY'),
(204, '7MONTHS IUD & HYSTECTOMY'),
(205, 'SURGERY'),
(206, 'DERMOID CYST'),
(207, 'CERVICAL POLYP'),
(208, 'HYPERTROPY@HEART'),
(209, 'AXILLA'),
(210, 'END. POLYP'),
(211, 'HERBERS'),
(212, 'TORSION TESTIS'),
(213, 'HERNIA @ VARICOCELE'),
(214, 'HERNIA  REPAIR'),
(215, 'TRACTION'),
(216, 'MTP & TAT'),
(217, 'LAP. DERMOID CYST'),
(218, 'MTP @ VEG CYST'),
(219, 'FIBROIDEVTOMY'),
(220, '2MOUNTHS'),
(221, '6MONTHS IUD'),
(222, 'BEREAST CASE'),
(223, '8 MONTHS @ DIARIYA'),
(224, 'NEPHRECTOMY'),
(225, 'GALL BLADDER STONE'),
(226, 'SUGAR CONTROL'),
(227, 'DISTENTION'),
(228, 'ADNEXAL CYST'),
(229, 'LAP CHOLE '),
(230, 'BACK PAIN'),
(231, 'WOUND INFECTION'),
(232, 'URITHERAL  CALCULAS'),
(233, 'CHOLECYSTECTOMY'),
(234, 'CYST REMOVAL'),
(235, '8MONTHS'),
(236, 'ST0NE @ PAIN'),
(237, 'BARTHOLIN  ABSCESS'),
(238, 'MYOMECTOMY @ HYSTECTOMY'),
(239, 'CERVICAL BIOPSY'),
(240, 'LAP APPENDIX'),
(241, 'DERMOID CYST LAP SURGERY'),
(242, 'LAPRACTOMY'),
(243, 'LS&OV.CYST'),
(244, 'STRICH'),
(245, 'ECTOBIC PREGENCY'),
(246, 'VAULT PROLAPSE'),
(247, 'AMBLICAL HERNIA'),
(248, 'HYSTERECTOMY @ HERNIA'),
(249, 'TERNINATION'),
(250, 'LAP HYSTRECTOMY'),
(251, 'CHOLECYSTECTOMY @ HYSTECTOMY'),
(252, 'BEREAST LUMP'),
(253, 'UNMARRIED'),
(254, 'VAG HYSTRECTOMY'),
(255, 'MIERINA'),
(256, 'PILONIDAL SINUS'),
(257, 'DERMINATION'),
(258, 'FRACTURE'),
(259, 'ABORTION'),
(260, 'LAMP BREST'),
(261, 'CX STICH'),
(262, 'DROWES'),
(263, 'DEROWES'),
(264, 'PALIPTATION'),
(265, 'STRONE'),
(266, 'COUTH'),
(267, 'HEADACHE'),
(268, 'IMC'),
(269, ' 2 MONTH AP PAIN'),
(270, 'GS'),
(271, 'COUGH'),
(272, 'PURS'),
(273, 'ADENOMYOSIS'),
(274, 'IV FLUIDS'),
(275, 'WEEKNESS'),
(276, 'CUT REMOVAL'),
(277, 'IBD'),
(278, ' BREAST CASE'),
(279, 'LOW SUGAR'),
(280, 'HISTRO LAP&00PHERACTOMY'),
(281, 'FIBROID CYST'),
(282, 'GAUNDICE'),
(283, 'BREAST CASE'),
(284, 'HYSTRO LAP'),
(285, 'HYSTERECTOMY DON'),
(286, 'HAEMOTHREAPY'),
(287, 'STERLATION'),
(288, 'LOOSE MOTION.'),
(289, 'B.P '),
(290, 'NEW BORN'),
(291, 'VAG HYSTRECTOMY\\'),
(292, 'LOOSE STOOLS'),
(293, 'DNC'),
(294, 'R.T.A'),
(295, 'ANAEMIA'),
(296, 'FEVER.'),
(297, 'LAG PAIN'),
(298, 'VOMITING.'),
(299, 'OPSARVATION');

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `m_category`
--

INSERT INTO `m_category` (`category_id`, `category_name`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, 'CATEGORY 1', 'user', '2020-06-19 17:44:46', NULL, NULL),
(2, 'CATEGORY 2', 'user', '2020-06-19 17:44:50', NULL, NULL);

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=15 ;

--
-- Dumping data for table `m_doctor`
--

INSERT INTO `m_doctor` (`doctor_id`, `doctor_name`, `specialist`, `address`, `mobileno`) VALUES
(1, 'DR.LAKSHMANAN', 'GENERAL ME', 'UDAYARPATTI,TIRUNELVELI', '9443808347'),
(2, 'DR.MEENA', '', 'nellai', '0'),
(3, 'DR.KUMARAGURU', 'BABY ', '', '0'),
(4, 'DR.RAMALAKSHMI', '', '', '0'),
(5, 'DR.SRINIVASAN', '', '', '0'),
(6, 'DR.GOPINATH', 'SURGEON', '', '0'),
(7, 'DR.MURUGESH', '', '', '0'),
(8, 'DR.PARIMALAM', '', '', '0'),
(9, 'DR.KANTHASWAMY', '', '', '0'),
(10, 'OTHERS', '', '', '0'),
(11, 'DR.SURESH', 'BABY', '', '9443080380'),
(12, 'GOKUL', 'UROLOGY', '', '0'),
(13, 'DR.MADHUBALA', 'OBG', '', '9443808346'),
(14, 'PERIYASAMY', '', '', '9791667170');

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `m_group`
--

INSERT INTO `m_group` (`group_id`, `category_id`, `group_name`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, 1, 'SUGAR', 'user', '2020-06-19 17:45:14', NULL, NULL),
(2, 1, 'RICE', 'user', '2020-06-19 17:45:21', NULL, NULL);

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `m_lab_test_fees`
--

INSERT INTO `m_lab_test_fees` (`lab_test_fees_id`, `test_name`, `test_description`, `amount`) VALUES
(1, 'glucose test', 'glu test descrip', 100.00),
(2, 'bp', 'bp test', 200.00),
(3, 'Diabetic Profile', 'Diabetic test description', 1000.00),
(4, 'CBC Test', 'cbc test description', 400.00);

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
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Dumping data for table `m_patient_registration`
--

INSERT INTO `m_patient_registration` (`patient_id`, `uhid`, `patient_name`, `age`, `dmy`, `gender`, `date_of_birth`, `next_of_kin`, `patient_address`, `patient_mobileno`, `visiting_id_no`, `consultant`, `date_of_reg`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, NULL, 'customer 1', NULL, NULL, NULL, '0000-00-00', NULL, '', '', NULL, NULL, NULL, 'user', '2020-06-19 17:44:25', NULL, NULL),
(2, NULL, 'customer  2', NULL, NULL, NULL, '0000-00-00', NULL, '', '', NULL, NULL, NULL, 'user', '2020-06-19 17:44:31', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `m_product`
--

CREATE TABLE IF NOT EXISTS `m_product` (
  `product_id` int(5) NOT NULL AUTO_INCREMENT,
  `product_name` varchar(100) NOT NULL,
  `category_id` int(3) NOT NULL,
  `group_id` int(3) NOT NULL,
  `product_details` varchar(500) NOT NULL,
  `hsn_code` varchar(50) NOT NULL,
  `gst` int(5) NOT NULL,
  `created_by` varchar(100) NOT NULL,
  `created_on` datetime NOT NULL,
  `updated_by` varchar(100) DEFAULT NULL,
  `updated_on` datetime DEFAULT NULL,
  PRIMARY KEY (`product_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `m_product`
--

INSERT INTO `m_product` (`product_id`, `product_name`, `category_id`, `group_id`, `product_details`, `hsn_code`, `gst`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, 'SUGAR 200G', 1, 1, '', '', 5, 'user', '2020-06-19 17:45:37', NULL, NULL),
(2, 'SUGAR 500G', 1, 1, '', '', 5, 'user', '2020-06-19 17:45:47', NULL, NULL),
(3, 'BASMATHI RICE 25 KG', 1, 2, '', '', 5, 'user', '2020-06-19 17:46:12', NULL, NULL),
(4, 'INDIA GATE RICE 1KG', 1, 2, '', '', 5, 'user', '2020-06-19 17:48:36', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `m_room`
--

CREATE TABLE IF NOT EXISTS `m_room` (
  `room_id` int(3) NOT NULL AUTO_INCREMENT,
  `room_name` varchar(50) NOT NULL,
  `amount` double(10,2) NOT NULL,
  `status` varchar(10) NOT NULL,
  PRIMARY KEY (`room_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=93 ;

--
-- Dumping data for table `m_room`
--

INSERT INTO `m_room` (`room_id`, `room_name`, `amount`, `status`) VALUES
(1, '201A', 200.00, 'A'),
(2, '201B', 200.00, 'A'),
(3, '202A', 200.00, 'U'),
(4, '202B', 200.00, 'U'),
(5, '203A', 200.00, 'A'),
(6, '203B', 200.00, 'A'),
(7, '204A', 200.00, 'A'),
(8, '204B', 200.00, 'A'),
(9, '205A', 200.00, 'A'),
(10, '205B', 200.00, 'A'),
(11, '206A', 200.00, 'A'),
(12, '206B', 200.00, 'A'),
(13, '207A', 200.00, 'A'),
(14, '207B', 200.00, 'A'),
(15, '208A', 200.00, 'A'),
(16, '210A', 200.00, 'A'),
(17, '210B', 200.00, 'A'),
(18, '211A', 200.00, 'U'),
(19, '211B', 200.00, 'A'),
(20, '212A', 200.00, 'A'),
(21, '212B', 200.00, 'U'),
(22, '213A', 200.00, 'A'),
(23, '213B', 200.00, 'A'),
(24, '214A', 200.00, 'A'),
(25, '101', 250.00, 'U'),
(26, '102', 250.00, 'U'),
(27, '103', 250.00, 'U'),
(28, '104', 250.00, 'U'),
(29, '105', 250.00, 'U'),
(30, '106', 250.00, 'U'),
(31, '109', 250.00, 'U'),
(32, '111', 250.00, 'A'),
(33, '112', 250.00, 'U'),
(34, '121', 250.00, 'U'),
(35, '122', 250.00, 'U'),
(36, '123', 250.00, 'U'),
(37, '124', 250.00, 'U'),
(38, '125', 250.00, 'U'),
(39, '126', 250.00, 'U'),
(40, '21', 250.00, 'U'),
(41, '22', 250.00, 'U'),
(42, '23', 250.00, 'U'),
(43, '24', 250.00, 'A'),
(44, '25', 250.00, 'U'),
(45, '26', 250.00, 'U'),
(46, '1', 300.00, 'U'),
(47, '2', 300.00, 'U'),
(48, '3', 300.00, 'A'),
(49, '5', 300.00, 'U'),
(50, '6', 300.00, 'A'),
(51, '7', 300.00, 'U'),
(52, '8', 300.00, 'U'),
(53, '10', 300.00, 'U'),
(54, '11', 300.00, 'U'),
(55, '107', 400.00, 'U'),
(56, '108', 400.00, 'U'),
(57, '301', 600.00, 'U'),
(58, '302', 600.00, 'U'),
(59, '303', 600.00, 'A'),
(60, '304', 600.00, 'U'),
(61, '305', 600.00, 'U'),
(62, '306', 600.00, 'U'),
(63, '307', 600.00, 'U'),
(64, '308', 600.00, 'U'),
(65, '309', 600.00, 'A'),
(66, '310', 600.00, 'A'),
(67, '311', 600.00, 'A'),
(68, '313', 600.00, 'A'),
(69, '314', 600.00, 'A'),
(70, '127', 400.00, 'U'),
(71, '401', 600.00, 'U'),
(72, '402', 600.00, 'A'),
(73, '403', 600.00, 'A'),
(74, '404', 600.00, 'U'),
(75, '405', 600.00, 'A'),
(76, '406', 600.00, 'U'),
(77, '407', 600.00, 'A'),
(78, '408', 600.00, 'A'),
(79, '409', 600.00, 'U'),
(80, '410', 600.00, 'A'),
(81, '411', 1200.00, 'A'),
(82, '412', 1200.00, 'A'),
(83, '9', 600.00, 'U'),
(84, '312', 1200.00, 'U'),
(85, '315', 1200.00, 'A'),
(86, '316', 1200.00, 'A'),
(87, '128', 1200.00, 'A'),
(88, '413', 1200.00, 'A'),
(89, '414', 1200.00, 'A'),
(90, '110', 1200.00, 'A'),
(91, '208B', 200.00, 'A'),
(92, '214B', 200.00, 'A');

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Dumping data for table `m_scan_test_fees`
--

INSERT INTO `m_scan_test_fees` (`scan_test_fees_id`, `scan_test_id`, `doctor_id`, `fees`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, 1, 1, 100.00, '', '0000-00-00 00:00:00', NULL, NULL),
(2, 1, 2, 200.00, '', '0000-00-00 00:00:00', NULL, NULL),
(3, 2, 1, 300.00, '', '0000-00-00 00:00:00', NULL, NULL),
(5, 2, 2, 390.00, '', '0000-00-00 00:00:00', NULL, NULL),
(6, 2, 3, 270.00, '', '0000-00-00 00:00:00', NULL, NULL);

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

--
-- Dumping data for table `m_supplier`
--

INSERT INTO `m_supplier` (`supplier_id`, `name`, `address`, `mobile_no`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, 'supplier 1', '', '', 'user', '2020-06-19 17:44:12', NULL, NULL),
(2, 'supplier 2', '', '', 'user', '2020-06-19 17:44:17', NULL, NULL);

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

--
-- Dumping data for table `outpatientdetails`
--

INSERT INTO `outpatientdetails` (`txno`, `tokenno`, `date`, `noontype`, `patient_id`, `uhid`, `casetype`, `casetype1`, `doctor_id`, `fees`, `payment_status`, `op_status`, `createdason`, `updatedason`) VALUES
(1, 1, '2020-05-30', 'Morning', 4357, '00-87-88', 'General', 'None', 2, 150, 'Paid', 'Processing', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(2, 2, '2020-05-30', 'Morning', 7268, '00-72-68', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(3, 3, '2020-05-30', 'Morning', 10003, '01-00-03', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(4, 4, '2020-05-30', 'Morning', 2859, '00-61-07', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(5, 5, '2020-05-30', 'Morning', 4443, '00-88-68', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(6, 6, '2020-05-30', 'Morning', 5243, '00-96-70', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(7, 1, '2020-05-30', 'Morning', 12001, '01-20-01', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(8, 7, '2020-05-30', 'Morning', 4695, '00-91-23', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(9, 1, '2020-05-30', 'Morning', 10285, '01-02-85', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(10, 2, '2020-05-30', 'Morning', 12002, '01-20-02', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(11, 8, '2020-05-30', 'Morning', 10222, '01-02-22', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(12, 3, '2020-05-30', 'Morning', 3281, '00-65-27', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(13, 2, '2020-05-30', 'Morning', 12003, '01-20-03', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(14, 3, '2020-05-30', 'Morning', 12004, '01-20-04', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(15, 4, '2020-05-30', 'Morning', 12005, '01-20-05', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(16, 5, '2020-05-30', 'Morning', 3461, '00-67-06', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(17, 6, '2020-05-30', 'Morning', 12006, '01-20-06', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(18, 9, '2020-05-30', 'Morning', 4278, '00-87-09', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(19, 10, '2020-05-30', 'Morning', 4125, '00-85-57', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(20, 7, '2020-05-30', 'Morning', 12007, '01-20-07', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(21, 11, '2020-05-30', 'Morning', 4632, '00-90-60', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(22, 8, '2020-05-30', 'Morning', 12008, '01-20-08', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(23, 12, '2020-05-30', 'Morning', 7219, '00-72-19', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(24, 13, '2020-05-30', 'Morning', 6992, '00-69-92', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(25, 9, '2020-05-30', 'Morning', 12009, '01-20-09', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(26, 14, '2020-05-30', 'Morning', 4113, '00-85-45', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(27, 15, '2020-05-30', 'Morning', 10196, '01-01-96', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(28, 16, '2020-05-30', 'Morning', 7863, '00-78-63', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(29, 17, '2020-05-30', 'Morning', 10126, '01-01-26', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(30, 1, '2020-05-31', 'Morning', 1, '00-00-01', 'General', 'None', 1, 0, 'Paid', 'Cancelled', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(31, 1, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(32, 2, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(33, 3, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(34, 4, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(35, 5, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(36, 6, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(37, 7, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(38, 8, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(39, 9, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(40, 10, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(41, 11, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(42, 12, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(43, 13, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(44, 14, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(45, 15, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(46, 16, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(47, 17, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(48, 18, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(49, 19, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(50, 20, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(51, 21, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(52, 22, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(53, 23, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(54, 24, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(55, 25, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(56, 26, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(57, 27, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(58, 28, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(59, 29, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(60, 30, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(61, 31, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(62, 32, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(63, 33, '2020-05-31', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(64, 1, '2020-06-01', 'Morning', 12010, '01-20-10-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(65, 2, '2020-06-01', 'Morning', 12011, '01-20-11-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Processing', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(66, 1, '2020-06-01', 'Morning', 1414, '00-20-16', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(67, 3, '2020-06-01', 'Morning', 12012, '01-20-12-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(68, 2, '2020-06-01', 'Morning', 10144, '01-01-44-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(69, 3, '2020-06-01', 'Morning', 5195, '00-96-22', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(70, 4, '2020-06-01', 'Morning', 12013, '01-20-13-0620', 'Emergency', 'None', 2, 300, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(71, 5, '2020-06-01', 'Morning', 12014, '01-20-14-0620', 'Emergency', 'None', 2, 300, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(72, 6, '2020-06-01', 'Morning', 12015, '01-20-15-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(73, 4, '2020-06-01', 'Morning', 1564, '00-21-69', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(74, 5, '2020-06-01', 'Morning', 10128, '01-01-28-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(75, 7, '2020-06-01', 'Morning', 12016, '01-20-16-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(76, 6, '2020-06-01', 'Morning', 10149, '01-01-49-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(77, 7, '2020-06-01', 'Morning', 6808, '00-68-08-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(78, 8, '2020-06-01', 'Morning', 12017, '01-20-17-0620', 'Emergency', 'None', 2, 300, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(79, 9, '2020-06-01', 'Morning', 12018, '01-20-18-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(80, 10, '2020-06-01', 'Morning', 12019, '01-20-19-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(81, 11, '2020-06-01', 'Morning', 12020, '01-20-20-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(82, 12, '2020-06-01', 'Morning', 12021, '01-20-21-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(83, 8, '2020-06-01', 'Morning', 6942, '00-69-42-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(84, 9, '2020-06-01', 'Morning', 4362, '00-87-93', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(85, 13, '2020-06-01', 'Morning', 12022, '01-20-22-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(86, 14, '2020-06-01', 'Morning', 12023, '01-20-23-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(87, 15, '2020-06-01', 'Morning', 12024, '01-20-24-0620', 'Emergency', 'None', 2, 350, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(88, 16, '2020-06-01', 'Morning', 4045, '00-84-77', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(89, 1, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(90, 2, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(91, 3, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(92, 4, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(93, 5, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(94, 6, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(95, 7, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(96, 8, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(97, 1, '2020-06-01', 'Evening', 12040, '01-20-40-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(98, 9, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(99, 10, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(100, 11, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(101, 12, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(102, 13, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(103, 14, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(104, 15, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(105, 16, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(106, 17, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(107, 18, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(108, 19, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(109, 20, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(110, 21, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(111, 22, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(112, 23, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(113, 24, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(114, 25, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(115, 26, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(116, 27, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(117, 28, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(118, 29, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(119, 30, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(120, 31, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(121, 32, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(122, 33, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(123, 34, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(124, 35, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(125, 36, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(126, 37, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(127, 38, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(128, 39, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(129, 40, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(130, 41, '2020-06-01', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(131, 1, '2020-06-02', 'Morning', 12041, '01-20-41-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(132, 1, '2020-06-02', 'Morning', 9986, '00-99-86-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(133, 2, '2020-06-02', 'Morning', 1804, '00-25-09', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(134, 2, '2020-06-02', 'Morning', 12042, '01-20-42-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(135, 3, '2020-06-02', 'Morning', 4165, '00-85-97', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(136, 4, '2020-06-02', 'Morning', 5536, '00-55-36-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(137, 5, '2020-06-02', 'Morning', 12043, '01-20-43-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(138, 6, '2020-06-02', 'Morning', 7152, '00-71-52-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(139, 7, '2020-06-02', 'Morning', 1323, '00-18-26', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(140, 3, '2020-06-02', 'Morning', 12044, '01-20-44-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(141, 8, '2020-06-02', 'Morning', 10041, '01-00-41-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(142, 9, '2020-06-02', 'Morning', 10001, '01-00-01-0620', 'General', 'Injection', 2, 250, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(143, 4, '2020-06-02', 'Morning', 12045, '01-20-45-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(144, 10, '2020-06-02', 'Morning', 6954, '00-69-54-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(145, 5, '2020-06-02', 'Morning', 12046, '01-20-46-0620', 'Emergency', 'Injection', 2, 300, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(146, 11, '2020-06-02', 'Morning', 7190, '00-71-90-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(147, 1, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'Injection', 2, 100, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(148, 6, '2020-06-02', 'Morning', 12047, '01-20-47-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(149, 1, '2020-06-02', 'Morning', 4831, '00-92-58', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(150, 12, '2020-06-02', 'Morning', 3782, '00-82-14', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(151, 13, '2020-06-02', 'Morning', 2393, '00-55-29', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(152, 7, '2020-06-02', 'Morning', 12048, '01-20-48-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(153, 14, '2020-06-02', 'Morning', 4650, '00-90-78', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(154, 15, '2020-06-02', 'Morning', 2100, '00-28-05', 'General', 'Injection', 2, 250, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(155, 16, '2020-06-02', 'Morning', 12049, '01-20-49-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(156, 17, '2020-06-02', 'Morning', 4663, '00-90-91', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(157, 8, '2020-06-02', 'Morning', 12050, '01-20-50-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(158, 9, '2020-06-02', 'Morning', 12051, '01-20-51-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(159, 10, '2020-06-02', 'Morning', 251, '00-02-31', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(160, 11, '2020-06-02', 'Morning', 12053, '01-20-53-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(161, 18, '2020-06-02', 'Morning', 161, '00-01-51', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(162, 19, '2020-06-02', 'Morning', 526, '00-04-49', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(163, 12, '2020-06-02', 'Morning', 12054, '01-20-54-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(164, 20, '2020-06-02', 'Morning', 3139, '00-63-87', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(165, 21, '2020-06-02', 'Morning', 12019, '01-20-19-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(166, 22, '2020-06-02', 'Morning', 10196, '01-01-96', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(167, 13, '2020-06-02', 'Morning', 12058, '01-20-58-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(168, 23, '2020-06-02', 'Morning', 9966, '00-99-66-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(169, 14, '2020-06-02', 'Morning', 12059, '01-20-59-0620', 'Emergency', 'None', 2, 0, 'Paid', 'Cancelled', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(170, 2, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(171, 3, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(172, 4, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(173, 5, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(174, 6, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(175, 7, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(176, 8, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(177, 9, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(178, 10, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(179, 11, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(180, 12, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(181, 13, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(182, 14, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(183, 15, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(184, 16, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(185, 17, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(186, 18, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(187, 19, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(188, 20, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(189, 21, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(190, 22, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(191, 23, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(192, 24, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(193, 25, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(194, 26, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(195, 27, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(196, 28, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(197, 29, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(198, 30, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(199, 31, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(200, 32, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(201, 33, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(202, 34, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(203, 35, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(204, 36, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(205, 37, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(206, 38, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(207, 39, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(208, 40, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(209, 41, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(210, 42, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(211, 43, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(212, 44, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(213, 45, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(214, 46, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(215, 47, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(216, 48, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(217, 49, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(218, 50, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(219, 51, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(220, 52, '2020-06-02', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(221, 1, '2020-06-03', 'Morning', 1612, '00-23-16', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(222, 2, '2020-06-03', 'Morning', 9991, '00-99-91-0620', 'General', 'None', 2, 0, 'NotPaid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(223, 3, '2020-06-03', 'Morning', 4006, '00-84-38', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(224, 4, '2020-06-03', 'Morning', 4665, '00-90-93', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(225, 5, '2020-06-03', 'Morning', 2626, '00-58-73', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(226, 6, '2020-06-03', 'Morning', 2557, '00-58-04', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(227, 7, '2020-06-03', 'Morning', 10151, '01-01-51-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(228, 8, '2020-06-03', 'Morning', 4802, '00-92-29', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(229, 9, '2020-06-03', 'Morning', 6996, '00-69-96-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(230, 1, '2020-06-03', 'Morning', 6996, '00-69-96-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(231, 2, '2020-06-03', 'Morning', 12067, '01-20-67-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(232, 10, '2020-06-03', 'Morning', 1316, '00-18-19', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(233, 11, '2020-06-03', 'Morning', 6663, '00-66-63-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(234, 12, '2020-06-03', 'Morning', 10177, '01-01-77-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(235, 13, '2020-06-03', 'Morning', 10016, '01-00-16-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(236, 14, '2020-06-03', 'Morning', 6957, '00-69-57-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(237, 15, '2020-06-03', 'Morning', 4238, '00-86-69', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(238, 16, '2020-06-03', 'Morning', 7086, '00-70-86-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(239, 17, '2020-06-03', 'Morning', 7426, '00-74-26-0620', 'General', 'None', 2, 0, 'NotPaid', 'Cancelled', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(240, 18, '2020-06-03', 'Morning', 7511, '00-75-11-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(241, 19, '2020-06-03', 'Morning', 1599, '00-23-03', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(242, 3, '2020-06-03', 'Morning', 1599, '00-23-03', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(243, 4, '2020-06-03', 'Morning', 4006, '00-84-38', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(244, 5, '2020-06-03', 'Morning', 10297, '01-02-97-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(245, 20, '2020-06-03', 'Morning', 2944, '00-61-92', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(246, 1, '2020-06-03', 'Morning', 12068, '01-20-68-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(247, 6, '2020-06-03', 'Morning', 10178, '01-01-78-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(248, 2, '2020-06-03', 'Morning', 12069, '01-20-69-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(249, 21, '2020-06-03', 'Morning', 4796, '00-92-23', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(250, 3, '2020-06-03', 'Morning', 12070, '01-20-70-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(251, 4, '2020-06-03', 'Morning', 12071, '01-20-71-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(252, 5, '2020-06-03', 'Morning', 2782, '00-60-29', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(253, 6, '2020-06-03', 'Morning', 3075, '00-63-24', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(254, 22, '2020-06-03', 'Morning', 7702, '00-77-02-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(255, 23, '2020-06-03', 'Morning', 4892, '00-93-19', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(256, 7, '2020-06-03', 'Morning', 7351, '00-73-51-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(257, 8, '2020-06-03', 'Morning', 5454, '00-98-81', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(258, 9, '2020-06-03', 'Morning', 12072, '01-20-72-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(259, 10, '2020-06-03', 'Morning', 3492, '00-67-43', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(260, 11, '2020-06-03', 'Morning', 6998, '00-69-98-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(261, 12, '2020-06-03', 'Morning', 5436, '00-98-63', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(262, 13, '2020-06-03', 'Morning', 12073, '01-20-73-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(263, 7, '2020-06-03', 'Morning', 7426, '00-74-26-0620', 'General', 'None', 1, 150, 'Paid', 'Processing', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(264, 8, '2020-06-03', 'Morning', 4802, '00-92-29', 'General', 'None', 1, 100, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(265, 1, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(266, 2, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(267, 3, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(268, 4, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(269, 5, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(270, 6, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(271, 7, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(272, 8, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(273, 9, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(274, 10, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(275, 11, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(276, 12, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(277, 13, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(278, 14, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(279, 15, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(280, 16, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(281, 17, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(282, 18, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(283, 19, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(284, 20, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(285, 21, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(286, 22, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(287, 23, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(288, 24, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(289, 25, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(290, 26, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(291, 27, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(292, 28, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(293, 29, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(294, 30, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(295, 31, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(296, 32, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(297, 33, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(298, 34, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(299, 35, '2020-06-03', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(300, 1, '2020-06-04', 'Morning', 10014, '01-00-14-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(301, 2, '2020-06-04', 'Morning', 7961, '00-79-61-0620', 'General', 'Injection', 2, 250, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(302, 1, '2020-06-04', 'Morning', 12088, '01-20-88-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(303, 3, '2020-06-04', 'Morning', 5368, '00-97-95', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(304, 4, '2020-06-04', 'Morning', 10001, '01-00-01-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(305, 5, '2020-06-04', 'Morning', 2593, '00-58-40', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(306, 6, '2020-06-04', 'Morning', 10030, '01-00-30-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(307, 2, '2020-06-04', 'Morning', 12089, '01-20-89-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(308, 1, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'Injection', 2, 100, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(309, 3, '2020-06-04', 'Morning', 12090, '01-20-90-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(310, 7, '2020-06-04', 'Morning', 6677, '00-66-77-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(311, 1, '2020-06-04', 'Morning', 7610, '00-76-10-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(312, 8, '2020-06-04', 'Morning', 3800, '00-82-32', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(313, 9, '2020-06-04', 'Morning', 4010, '00-84-42', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(314, 4, '2020-06-04', 'Morning', 12091, '01-20-91-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(315, 5, '2020-06-04', 'Morning', 12092, '01-20-92-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(316, 10, '2020-06-04', 'Morning', 12093, '01-20-93-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(317, 11, '2020-06-04', 'Morning', 4867, '00-92-94', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(318, 12, '2020-06-04', 'Morning', 7155, '00-71-55-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(319, 6, '2020-06-04', 'Morning', 12094, '01-20-94-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(320, 7, '2020-06-04', 'Morning', 12095, '01-20-95-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(321, 13, '2020-06-04', 'Morning', 10184, '01-01-84-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(322, 14, '2020-06-04', 'Morning', 4028, '00-84-60', 'General', 'Injection', 2, 250, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(323, 8, '2020-06-04', 'Morning', 12096, '01-20-96-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(324, 9, '2020-06-04', 'Morning', 12097, '01-20-97-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(325, 15, '2020-06-04', 'Morning', 2742, '00-59-89', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(326, 16, '2020-06-04', 'Morning', 7037, '00-70-37-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(327, 10, '2020-06-04', 'Morning', 12098, '01-20-98-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(328, 17, '2020-06-04', 'Morning', 485, '00-04-13', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(329, 11, '2020-06-04', 'Morning', 12099, '01-20-99-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00');
INSERT INTO `outpatientdetails` (`txno`, `tokenno`, `date`, `noontype`, `patient_id`, `uhid`, `casetype`, `casetype1`, `doctor_id`, `fees`, `payment_status`, `op_status`, `createdason`, `updatedason`) VALUES
(330, 2, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(331, 3, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(332, 4, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(333, 5, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(334, 6, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(335, 7, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(336, 8, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(337, 9, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(338, 10, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(339, 11, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(340, 12, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(341, 13, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(342, 14, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(343, 15, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(344, 16, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(345, 17, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(346, 18, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(347, 19, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(348, 20, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(349, 21, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(350, 22, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(351, 23, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(352, 24, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(353, 25, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(354, 26, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(355, 27, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(356, 28, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(357, 29, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(358, 30, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(359, 31, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(360, 32, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(361, 33, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(362, 34, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(363, 35, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(364, 36, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(365, 37, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(366, 38, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(367, 39, '2020-06-04', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(368, 1, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'Injection', 2, 100, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(369, 2, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'Injection', 2, 100, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(370, 1, '2020-06-05', 'Morning', 499, '00-04-25', 'General', 'None', 2, 250, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(371, 2, '2020-06-05', 'Morning', 3766, '00-81-98', 'General', 'None', 2, 250, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(372, 3, '2020-06-05', 'Morning', 10281, '01-02-81-0620', 'General', 'None', 2, 250, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(373, 4, '2020-06-05', 'Morning', 7641, '00-76-41-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(374, 5, '2020-06-05', 'Morning', 5427, '00-98-54', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(375, 6, '2020-06-05', 'Morning', 10227, '01-02-27-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(376, 1, '2020-06-05', 'Morning', 12123, '01-21-23-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(377, 7, '2020-06-05', 'Morning', 10007, '01-00-07-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(378, 8, '2020-06-05', 'Morning', 7158, '00-71-58-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(379, 1, '2020-06-05', 'Morning', 12124, '01-21-24-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(380, 9, '2020-06-05', 'Morning', 7252, '00-72-52-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(381, 10, '2020-06-05', 'Morning', 12005, '01-20-05', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(382, 3, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'Injection', 2, 100, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(383, 11, '2020-06-05', 'Morning', 5396, '00-98-23', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(384, 2, '2020-06-05', 'Morning', 12126, '01-21-26-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(385, 3, '2020-06-05', 'Morning', 12127, '01-21-27-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(386, 12, '2020-06-05', 'Morning', 4955, '00-93-82', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(387, 13, '2020-06-05', 'Morning', 7152, '00-71-52-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(388, 14, '2020-06-05', 'Morning', 4367, '00-87-98', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(389, 15, '2020-06-05', 'Morning', 3469, '00-67-20', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(390, 16, '2020-06-05', 'Morning', 10193, '01-01-93-0620', 'General', 'None', 2, 0, 'NotPaid', 'Cancelled', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(391, 2, '2020-06-05', 'Morning', 10193, '01-01-93-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(392, 3, '2020-06-05', 'Morning', 3616, '00-80-49', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(393, 4, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(394, 5, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(395, 6, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(396, 7, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(397, 8, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(398, 9, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(399, 10, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(400, 11, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(401, 12, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(402, 13, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(403, 14, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(404, 15, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(405, 16, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(406, 17, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(407, 18, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(408, 19, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(409, 20, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(410, 21, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(411, 22, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 0, 'NotPaid', 'Cancelled', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(412, 23, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 0, 'NotPaid', 'Cancelled', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(413, 24, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 0, 'NotPaid', 'Cancelled', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(414, 25, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 0, 'NotPaid', 'Cancelled', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(415, 26, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(416, 27, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(417, 28, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(418, 29, '2020-06-05', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(419, 1, '2020-06-06', 'Morning', 9954, '00-99-54-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(420, 2, '2020-06-06', 'Morning', 7107, '00-71-07-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(421, 3, '2020-06-06', 'Morning', 5023, '00-94-50', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(422, 4, '2020-06-06', 'Morning', 1834, '00-25-38', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(423, 1, '2020-06-06', 'Morning', 12132, '01-21-32-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(424, 2, '2020-06-06', 'Morning', 12133, '01-21-33-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(425, 1, '2020-06-06', 'Morning', 12134, '01-21-34-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(426, 5, '2020-06-06', 'Morning', 1901, '00-26-06', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(427, 2, '2020-06-06', 'Morning', 1901, '00-26-06', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(428, 6, '2020-06-06', 'Morning', 7703, '00-77-03-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(429, 3, '2020-06-06', 'Morning', 7703, '00-77-03-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(430, 3, '2020-06-06', 'Morning', 12135, '01-21-35-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(431, 4, '2020-06-06', 'Morning', 12136, '01-21-36-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(432, 5, '2020-06-06', 'Morning', 12137, '01-21-37-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(433, 7, '2020-06-06', 'Morning', 3523, '00-79-63', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(434, 8, '2020-06-06', 'Morning', 9995, '00-99-95-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(435, 6, '2020-06-06', 'Morning', 12138, '01-21-38-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(436, 7, '2020-06-06', 'Morning', 12139, '01-21-39-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(437, 9, '2020-06-06', 'Morning', 7563, '00-75-63-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(438, 10, '2020-06-06', 'Morning', 8885, '00-88-85-0620', 'General', 'Injection', 2, 250, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(439, 8, '2020-06-06', 'Morning', 12140, '01-21-40-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(440, 11, '2020-06-06', 'Morning', 5053, '00-94-80', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(441, 4, '2020-06-06', 'Morning', 3281, '00-65-27', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(442, 9, '2020-06-06', 'Morning', 12141, '01-21-41-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(443, 12, '2020-06-06', 'Morning', 4917, '00-93-44', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(444, 10, '2020-06-06', 'Morning', 12142, '01-21-42-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(445, 13, '2020-06-06', 'Morning', 3171, '00-64-19', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(446, 11, '2020-06-06', 'Morning', 12143, '01-21-43-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(447, 5, '2020-06-06', 'Morning', 5260, '00-96-87', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(448, 14, '2020-06-06', 'Morning', 5451, '00-98-78', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(449, 6, '2020-06-06', 'Morning', 7736, '00-77-36-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(450, 15, '2020-06-06', 'Morning', 7062, '00-70-62-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(451, 16, '2020-06-06', 'Morning', 12015, '01-20-15-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(452, 17, '2020-06-06', 'Morning', 4662, '00-90-90', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(453, 18, '2020-06-06', 'Morning', 5539, '00-55-39-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(454, 19, '2020-06-06', 'Morning', 5114, '00-95-41', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(455, 12, '2020-06-06', 'Morning', 12145, '01-21-45-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(456, 20, '2020-06-06', 'Morning', 10224, '01-02-24-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(457, 21, '2020-06-06', 'Morning', 7021, '00-70-21-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(458, 7, '2020-06-06', 'Morning', 12142, '01-21-42-0620', 'General', 'None', 1, 100, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(459, 1, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(460, 2, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(461, 3, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(462, 4, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(463, 5, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(464, 6, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(465, 7, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(466, 8, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(467, 9, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(468, 10, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(469, 11, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(470, 12, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(471, 13, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(472, 14, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(473, 15, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(474, 16, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(475, 17, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(476, 18, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(477, 19, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(478, 20, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(479, 21, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(480, 22, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(481, 23, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(482, 24, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(483, 25, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(484, 26, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(485, 27, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(486, 28, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(487, 29, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(488, 30, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(489, 31, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(490, 32, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(491, 33, '2020-06-06', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(492, 1, '2020-06-08', 'Morning', 4110, '00-85-42', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(493, 2, '2020-06-08', 'Morning', 7460, '00-74-60', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(494, 1, '2020-06-08', 'Morning', 12161, '01-21-61-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(495, 2, '2020-06-08', 'Morning', 12162, '01-21-62-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(496, 1, '2020-06-08', 'Morning', 12163, '01-21-63-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(497, 3, '2020-06-08', 'Morning', 3735, '00-81-67', 'General', 'Injection', 2, 250, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(498, 1, '2020-06-08', 'Morning', 1414, '00-20-16', 'Others', 'Injection', 2, 100, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(499, 4, '2020-06-08', 'Morning', 4762, '00-91-89', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(500, 5, '2020-06-08', 'Morning', 9985, '00-99-85', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(501, 2, '2020-06-08', 'Morning', 5252, '00-96-79', 'Others', 'Injection', 2, 100, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(502, 2, '2020-06-08', 'Morning', 12164, '01-21-64-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(503, 3, '2020-06-08', 'Morning', 12165, '01-21-65-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(504, 6, '2020-06-08', 'Morning', 935, '00-14-05', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(505, 3, '2020-06-08', 'Morning', 12166, '01-21-66-0620', 'General', 'None', 1, 350, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(506, 4, '2020-06-08', 'Morning', 12167, '01-21-67-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(507, 7, '2020-06-08', 'Morning', 2665, '00-59-12', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(508, 8, '2020-06-08', 'Morning', 9997, '00-99-97', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(509, 5, '2020-06-08', 'Morning', 12168, '01-21-68-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(510, 9, '2020-06-08', 'Morning', 5490, '00-99-18', 'General', 'Injection', 2, 250, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(511, 6, '2020-06-08', 'Morning', 12169, '01-21-69-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(512, 10, '2020-06-08', 'Morning', 7731, '00-77-31', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(513, 7, '2020-06-08', 'Morning', 12170, '01-21-70-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(514, 11, '2020-06-08', 'Morning', 10073, '01-00-73', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(515, 12, '2020-06-08', 'Morning', 10028, '01-00-28', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(516, 13, '2020-06-08', 'Morning', 12046, '01-20-46-0620', 'General', 'Injection', 2, 250, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(517, 8, '2020-06-08', 'Morning', 12173, '01-21-73-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(518, 14, '2020-06-08', 'Morning', 7242, '00-72-42', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(519, 15, '2020-06-08', 'Morning', 4464, '00-88-88', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(520, 16, '2020-06-08', 'Morning', 2614, '00-58-61', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(521, 17, '2020-06-08', 'Morning', 12099, '01-20-99-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(522, 18, '2020-06-08', 'Morning', 6999, '00-69-99', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(523, 19, '2020-06-08', 'Morning', 6915, '00-69-15', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(524, 20, '2020-06-08', 'Morning', 10091, '01-00-91', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(525, 21, '2020-06-08', 'Morning', 10023, '01-00-23', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(526, 22, '2020-06-08', 'Morning', 3980, '00-84-12', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(527, 23, '2020-06-08', 'Morning', 2960, '00-62-08', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(528, 24, '2020-06-08', 'Morning', 10237, '01-02-37', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(529, 25, '2020-06-08', 'Morning', 1789, '00-24-93', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(530, 9, '2020-06-08', 'Morning', 12175, '01-21-75-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(531, 26, '2020-06-08', 'Morning', 3773, '00-82-05', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(532, 27, '2020-06-08', 'Morning', 7122, '00-71-22', 'General', 'Injection', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(533, 28, '2020-06-08', 'Morning', 7389, '00-73-89', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(534, 29, '2020-06-08', 'Morning', 3744, '00-81-76', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(535, 30, '2020-06-08', 'Morning', 2650, '00-58-97', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(536, 10, '2020-06-08', 'Morning', 12176, '01-21-76-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(537, 31, '2020-06-08', 'Morning', 12107, '01-21-07-0620', 'General', 'None', 2, 0, 'NotPaid', 'Cancelled', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(538, 11, '2020-06-08', 'Morning', 12177, '01-21-77-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(539, 32, '2020-06-08', 'Morning', 3390, '00-66-36', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(540, 33, '2020-06-08', 'Morning', 3966, '00-83-98', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(541, 4, '2020-06-08', 'Morning', 7122, '00-71-22', 'General', 'None', 1, 100, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(542, 3, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(543, 4, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(544, 5, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(545, 6, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(546, 7, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(547, 8, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(548, 9, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(549, 10, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(550, 11, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(551, 12, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(552, 13, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(553, 14, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(554, 15, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(555, 16, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(556, 17, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(557, 18, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(558, 19, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(559, 20, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(560, 21, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(561, 22, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(562, 23, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(563, 24, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(564, 25, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(565, 26, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(566, 27, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(567, 28, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(568, 29, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(569, 30, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(570, 31, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(571, 32, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(572, 33, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(573, 34, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(574, 35, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(575, 36, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(576, 37, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(577, 38, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(578, 39, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(579, 40, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(580, 41, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(581, 42, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(582, 43, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(583, 44, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(584, 45, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(585, 46, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(586, 47, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(587, 48, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(588, 49, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(589, 50, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(590, 51, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(591, 52, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(592, 53, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(593, 54, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(594, 55, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(595, 56, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(596, 57, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(597, 58, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(598, 59, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(599, 60, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(600, 61, '2020-06-08', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(601, 1, '2020-06-09', 'Morning', 4591, '00-90-19', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(602, 2, '2020-06-09', 'Morning', 4108, '00-85-40', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(603, 3, '2020-06-09', 'Morning', 3295, '00-65-41', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(604, 4, '2020-06-09', 'Morning', 5024, '00-94-51', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(605, 5, '2020-06-09', 'Morning', 4434, '00-88-59', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(606, 6, '2020-06-09', 'Morning', 2859, '00-61-07', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(607, 1, '2020-06-09', 'Morning', 12195, '01-21-95-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '2020-06-05 10:20:07', '0000-00-00 00:00:00'),
(608, 7, '2020-06-09', 'Morning', 4487, '00-89-11', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(609, 2, '2020-06-09', 'Morning', 12196, '01-21-96-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(610, 3, '2020-06-09', 'Morning', 12197, '01-21-97-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(611, 4, '2020-06-09', 'Morning', 12198, '01-21-98-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(612, 1, '2020-06-09', 'Morning', 10297, '01-02-97-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(613, 8, '2020-06-09', 'Morning', 4118, '00-85-50', 'General', 'None', 2, 0, 'NotPaid', 'Cancelled', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(614, 2, '2020-06-09', 'Morning', 4118, '00-85-50', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(615, 9, '2020-06-09', 'Morning', 7038, '00-70-38', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(616, 5, '2020-06-09', 'Morning', 12201, '01-22-01-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(617, 6, '2020-06-09', 'Morning', 12202, '01-22-02-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(618, 10, '2020-06-09', 'Morning', 4612, '00-90-40', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(619, 3, '2020-06-09', 'Morning', 10178, '01-01-78-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(620, 4, '2020-06-09', 'Morning', 12205, '01-22-05-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(621, 11, '2020-06-09', 'Morning', 12206, '01-22-06-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(622, 12, '2020-06-09', 'Morning', 5190, '00-96-17', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(623, 13, '2020-06-09', 'Morning', 10178, '01-01-78-0620', 'General', 'None', 2, 0, 'NotPaid', 'Cancelled', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(624, 1, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(625, 2, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(626, 3, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(627, 4, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(628, 5, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(629, 6, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(630, 7, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(631, 8, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(632, 9, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(633, 10, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(634, 11, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(635, 12, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(636, 13, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(637, 14, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(638, 15, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(639, 16, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(640, 17, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(641, 18, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(642, 19, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(643, 20, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(644, 21, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(645, 22, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(646, 23, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(647, 24, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(648, 25, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(649, 26, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(650, 27, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(651, 28, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(652, 29, '2020-06-09', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(653, 1, '2020-06-10', 'Morning', 5394, '00-98-21', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(654, 2, '2020-06-10', 'Morning', 9985, '00-99-85', 'General', 'None', 2, 0, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(655, 1, '2020-06-10', 'Morning', 12218, '01-22-18-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(656, 2, '2020-06-10', 'Morning', 12219, '01-22-19-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00');
INSERT INTO `outpatientdetails` (`txno`, `tokenno`, `date`, `noontype`, `patient_id`, `uhid`, `casetype`, `casetype1`, `doctor_id`, `fees`, `payment_status`, `op_status`, `createdason`, `updatedason`) VALUES
(657, 3, '2020-06-10', 'Morning', 4125, '00-85-57', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(658, 3, '2020-06-10', 'Morning', 12220, '01-22-20-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(659, 4, '2020-06-10', 'Morning', 6996, '00-69-96-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(660, 1, '2020-06-10', 'Morning', 6996, '00-69-96-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(661, 5, '2020-06-10', 'Morning', 6927, '00-69-27', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(662, 4, '2020-06-10', 'Morning', 12222, '01-22-22-0620', 'Emergency', 'Injection', 2, 300, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(663, 6, '2020-06-10', 'Morning', 10239, '01-02-39', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(664, 7, '2020-06-10', 'Morning', 5490, '00-99-18', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(665, 8, '2020-06-10', 'Morning', 12223, '01-22-23-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(666, 9, '2020-06-10', 'Morning', 12095, '01-20-95-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(667, 10, '2020-06-10', 'Morning', 2508, '00-56-66', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(668, 11, '2020-06-10', 'Morning', 7140, '00-71-40', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(669, 12, '2020-06-10', 'Morning', 2118, '00-28-23', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(670, 13, '2020-06-10', 'Morning', 6980, '00-69-80', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(671, 14, '2020-06-10', 'Morning', 1241, '00-17-05', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(672, 15, '2020-06-10', 'Morning', 10051, '01-00-51', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(673, 16, '2020-06-10', 'Morning', 7125, '00-71-25', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(674, 17, '2020-06-10', 'Morning', 10039, '01-00-39', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(675, 18, '2020-06-10', 'Morning', 1866, '00-25-69', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(676, 19, '2020-06-10', 'Morning', 7336, '00-73-36', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(677, 20, '2020-06-10', 'Morning', 5139, '00-95-66', 'General', 'Injection', 2, 250, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(678, 21, '2020-06-10', 'Morning', 1323, '00-18-26', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(679, 5, '2020-06-10', 'Morning', 12225, '01-22-25-0620', 'Emergency', 'None', 2, 300, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(680, 2, '2020-06-10', 'Morning', 1599, '00-23-03', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(681, 3, '2020-06-10', 'Morning', 1599, '00-23-03', 'General', 'None', 1, 0, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(682, 22, '2020-06-10', 'Morning', 1599, '00-23-03', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(683, 4, '2020-06-10', 'Morning', 12218, '01-22-18-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(684, 23, '2020-06-10', 'Morning', 9962, '00-99-62', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(685, 24, '2020-06-10', 'Morning', 7334, '00-73-34', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(686, 25, '2020-06-10', 'Morning', 7194, '00-71-94', 'General', 'Injection', 2, 250, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(687, 26, '2020-06-10', 'Morning', 7216, '00-72-16', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(688, 6, '2020-06-10', 'Morning', 12226, '01-22-26-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(689, 27, '2020-06-10', 'Morning', 1289, '00-17-53', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(690, 7, '2020-06-10', 'Morning', 12227, '01-22-27-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(691, 28, '2020-06-10', 'Morning', 10288, '01-02-88', 'General', 'Injection', 2, 250, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(692, 8, '2020-06-10', 'Morning', 12231, '01-22-31-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(693, 29, '2020-06-10', 'Morning', 9978, '00-99-78', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(694, 30, '2020-06-10', 'Morning', 7326, '00-73-26', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(695, 9, '2020-06-10', 'Morning', 12233, '01-22-33-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(696, 10, '2020-06-10', 'Morning', 12234, '01-22-34-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(697, 31, '2020-06-10', 'Morning', 4893, '00-93-20', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(698, 11, '2020-06-10', 'Morning', 12235, '01-22-35-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(699, 32, '2020-06-10', 'Morning', 3664, '00-80-97', 'General', 'None', 2, 0, 'NotPaid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(700, 5, '2020-06-10', 'Morning', 12234, '01-22-34-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(701, 6, '2020-06-10', 'Morning', 4975, '00-94-02', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(702, 1, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(703, 2, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(704, 3, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(705, 4, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(706, 5, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(707, 6, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(708, 7, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(709, 8, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(710, 9, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(711, 10, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(712, 11, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(713, 12, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(714, 13, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(715, 14, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(716, 15, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(717, 16, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(718, 17, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(719, 18, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(720, 19, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(721, 20, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(722, 21, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(723, 22, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(724, 23, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(725, 24, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(726, 25, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(727, 26, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(728, 27, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(729, 28, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(730, 29, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(731, 30, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(732, 31, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(733, 32, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(734, 33, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(735, 34, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(736, 35, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(737, 36, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(738, 37, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(739, 38, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(740, 39, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(741, 40, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(742, 41, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(743, 42, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(744, 43, '2020-06-10', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(745, 1, '2020-06-11', 'Morning', 10072, '01-00-72', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(746, 1, '2020-06-11', 'Morning', 12247, '01-22-47-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(747, 2, '2020-06-11', 'Morning', 12248, '01-22-48-0620', 'Emergency', 'None', 2, 300, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(748, 3, '2020-06-11', 'Morning', 12249, '01-22-49-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(749, 4, '2020-06-11', 'Morning', 12250, '01-22-50-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(750, 2, '2020-06-11', 'Morning', 7319, '00-73-19', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(751, 5, '2020-06-11', 'Morning', 12251, '01-22-51-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(752, 6, '2020-06-11', 'Morning', 12252, '01-22-52-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(753, 3, '2020-06-11', 'Morning', 3461, '00-67-06', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(754, 4, '2020-06-11', 'Morning', 3071, '00-63-20', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(755, 5, '2020-06-11', 'Morning', 12162, '01-21-62-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(756, 1, '2020-06-11', 'Morning', 12255, '01-22-55-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(757, 2, '2020-06-11', 'Morning', 12256, '01-22-56-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(758, 3, '2020-06-11', 'Morning', 12257, '01-22-57-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(759, 7, '2020-06-11', 'Morning', 12258, '01-22-58-0620', 'Emergency', 'None', 2, 300, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(760, 8, '2020-06-11', 'Morning', 1414, '00-20-16', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(761, 9, '2020-06-11', 'Morning', 12259, '01-22-59-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(762, 4, '2020-06-11', 'Morning', 12260, '01-22-60-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(763, 5, '2020-06-11', 'Morning', 12261, '01-22-61-0620', 'General', 'None', 1, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(764, 6, '2020-06-11', 'Morning', 12262, '01-22-62-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(765, 10, '2020-06-11', 'Morning', 12263, '01-22-63-0620', 'Emergency', 'None', 2, 300, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(766, 6, '2020-06-11', 'Morning', 12264, '01-22-64-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(767, 11, '2020-06-11', 'Morning', 12265, '01-22-65-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(768, 1, '2020-06-11', 'Morning', 5404, '00-98-31', 'Others', 'None', 2, 100, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(769, 12, '2020-06-11', 'Morning', 12266, '01-22-66-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(770, 7, '2020-06-11', 'Morning', 4366, '00-87-97', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(771, 8, '2020-06-11', 'Morning', 12267, '01-22-67-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(772, 13, '2020-06-11', 'Morning', 12268, '01-22-68-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(773, 9, '2020-06-11', 'Morning', 7034, '00-70-34', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(774, 10, '2020-06-11', 'Morning', 9996, '00-99-96', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(775, 11, '2020-06-11', 'Morning', 3257, '00-65-03', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(776, 14, '2020-06-11', 'Morning', 12270, '01-22-70-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(777, 15, '2020-06-11', 'Morning', 12271, '01-22-71-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(778, 16, '2020-06-11', 'Morning', 12272, '01-22-72-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(779, 17, '2020-06-11', 'Morning', 12273, '01-22-73-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(780, 12, '2020-06-11', 'Morning', 5074, '00-95-01', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(781, 13, '2020-06-11', 'Morning', 10172, '01-01-72', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(782, 18, '2020-06-11', 'Morning', 12276, '01-22-76-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(783, 14, '2020-06-11', 'Morning', 6656, '00-66-56', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(784, 19, '2020-06-11', 'Morning', 10099, '01-00-99', 'Emergency', 'None', 2, 250, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(785, 2, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(786, 3, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(787, 4, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(788, 5, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(789, 6, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(790, 7, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(791, 8, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(792, 9, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(793, 10, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(794, 11, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(795, 12, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(796, 13, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(797, 14, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(798, 15, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(799, 16, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(800, 17, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(801, 18, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(802, 19, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(803, 20, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(804, 21, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(805, 22, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(806, 23, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(807, 24, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(808, 25, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(809, 26, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(810, 27, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(811, 28, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(812, 29, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(813, 30, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(814, 31, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(815, 32, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(816, 33, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(817, 34, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(818, 35, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(819, 36, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(820, 37, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(821, 38, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(822, 39, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(823, 40, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(824, 41, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(825, 42, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(826, 43, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(827, 44, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(828, 45, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(829, 46, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(830, 47, '2020-06-11', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(831, 1, '2020-06-12', 'Morning', 3528, '00-79-67', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(832, 2, '2020-06-12', 'Morning', 509, '00-04-33', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(833, 3, '2020-06-12', 'Morning', 12165, '01-21-65-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(834, 1, '2020-06-12', 'Morning', 12289, '01-22-89-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(835, 1, '2020-06-12', 'Morning', 12290, '01-22-90-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(836, 4, '2020-06-12', 'Morning', 4260, '00-86-91', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(837, 1, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'Injection', 2, 100, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(838, 2, '2020-06-12', 'Morning', 12291, '01-22-91-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(839, 5, '2020-06-12', 'Morning', 4603, '00-90-31', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(840, 6, '2020-06-12', 'Morning', 3979, '00-84-11', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(841, 3, '2020-06-12', 'Morning', 12292, '01-22-92-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(842, 7, '2020-06-12', 'Morning', 7219, '00-72-19', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(843, 8, '2020-06-12', 'Morning', 12293, '01-22-93-0620', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(844, 4, '2020-06-12', 'Morning', 12294, '01-22-94-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(845, 9, '2020-06-12', 'Morning', 4960, '00-93-87', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(846, 5, '2020-06-12', 'Morning', 5401, '00-98-28', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(847, 6, '2020-06-12', 'Morning', 12295, '01-22-95-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(848, 7, '2020-06-12', 'Morning', 12297, '01-22-97-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(849, 8, '2020-06-12', 'Morning', 12296, '01-22-96-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(850, 2, '2020-06-12', 'Morning', 3281, '00-65-27', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(851, 10, '2020-06-12', 'Morning', 10054, '01-00-54', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(852, 3, '2020-06-12', 'Morning', 7731, '00-77-31', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(853, 4, '2020-06-12', 'Morning', 7610, '00-76-10-0620', 'General', 'None', 1, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(854, 9, '2020-06-12', 'Morning', 12298, '01-22-98-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(855, 10, '2020-06-12', 'Morning', 12299, '01-22-99-0620', 'Emergency', 'None', 2, 200, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(856, 11, '2020-06-12', 'Morning', 7336, '00-73-36', 'General', 'None', 2, 150, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(857, 2, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(858, 3, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(859, 4, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(860, 5, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(861, 6, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(862, 7, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(863, 8, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(864, 9, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(865, 10, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(866, 11, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(867, 12, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(868, 13, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(869, 14, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(870, 15, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(871, 16, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(872, 17, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(873, 18, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(874, 19, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(875, 20, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(876, 21, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(877, 22, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(878, 23, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(879, 24, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(880, 25, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(881, 26, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(882, 27, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'Anc', 2, 0, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(883, 28, '2020-06-12', 'Morning', 11999, '01-19-99-0520', 'Others', 'GreenFile', 2, 50, 'Paid', 'Completed', '0000-00-00 00:00:00', '0000-00-00 00:00:00'),
(884, 1, '2020-06-13', 'Morning', 12309, '01-23-09-0620', 'General', 'None', 1, 100, 'Paid', 'Completed', '2020-06-13 07:15:06', '2020-06-13 07:20:21'),
(885, 2, '2020-06-13', 'Morning', 1, '00-00-01', 'General', 'None', 1, 100, 'Paid', 'Processing', '2020-06-13 07:17:46', '2020-06-13 07:17:46'),
(886, 1, '2020-06-13', 'Evening', 300, '00-02-75', 'General', 'None', 13, 100, 'Paid', 'Processing', '2020-06-13 17:11:46', '2020-06-13 17:11:46');

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

--
-- Dumping data for table `purchase`
--

INSERT INTO `purchase` (`purchase_id`, `date`, `supplier_id`, `bill_invoice_no`, `freight`, `others`, `less_amount`, `total_amount`) VALUES
(1, '2020-06-19', 1, 'S1', 0.00, 0.00, 0.00, 6510.00),
(2, '2020-06-18', 2, 's2', 0.00, 0.00, 0.00, 897.75);

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

--
-- Dumping data for table `purchase_details`
--

INSERT INTO `purchase_details` (`purchase_id`, `txno`, `product_id`, `qty`, `batch_id`, `expiry_date`, `mrp`, `purchase_rate`, `discount`, `gst`, `total`) VALUES
(1, 1, 3, 5, 'ABC', '2020-09-19', 1250.00, 1000.00, 0.00, 5.00, 5250.00),
(1, 2, 4, 15, 'DEF', '2020-09-19', 100.00, 80.00, 0.00, 5.00, 1260.00),
(2, 1, 1, 30, 'ABC12', '2020-09-19', 10.00, 7.50, 0.00, 5.00, 236.25),
(2, 2, 2, 30, 'def23', '2020-09-19', 25.00, 21.00, 0.00, 5.00, 661.50);

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `purchase_return`
--

INSERT INTO `purchase_return` (`purchase_return_id`, `purchase_id`, `date`, `product_id`, `qty`, `mrp`, `batch_id`, `expiry_date`, `reason`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, 1, '2020-06-19', 3, 1.00, 1250.00, 'ABC', '9/19/2020  12:00:00 AM', 'PURCHASE RETURN damage', 'user', '2020-06-19 18:41:42', NULL, NULL);

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

--
-- Dumping data for table `sales`
--

INSERT INTO `sales` (`sales_id`, `date`, `patient_id`, `less_amount`, `service_amount`, `total_amount`, `despatch`, `destination`, `mode_of_payment`, `terms_of_delivery`, `vehicle_no`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, '2020-06-19', 2, 0.00, '0', 1280.00, '', '', 'Cash', 'IP', '', 'user', '2020-06-19 17:53:31', NULL, NULL),
(2, '2020-06-19', 1, 0.00, '0', 550.00, '', '', 'Cash', 'IP', '', 'user', '2020-06-19 17:54:25', NULL, NULL);

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

--
-- Dumping data for table `sales_details`
--

INSERT INTO `sales_details` (`sales_id`, `txno`, `product_id`, `batch_id`, `expiry_date`, `qty`, `unit_rate`, `amount`, `gst`, `discount_percentage`, `unit_mrp`) VALUES
(1, 1, 3, 'ABC', '2020-09-19', 1, 1190.48, 1190.48, 5.00, 0.00, 1250.00),
(1, 2, 1, 'ABC12', '2020-09-19', 3, 9.52, 28.56, 5.00, 0.00, 10.00),
(2, 1, 4, 'DEF', '2020-09-19', 5, 95.24, 476.20, 5.00, 0.00, 100.00),
(2, 2, 2, 'def23', '2020-09-19', 2, 23.81, 47.62, 5.00, 0.00, 25.00);

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=2 ;

--
-- Dumping data for table `sales_return`
--

INSERT INTO `sales_return` (`sales_return_id`, `sales_id`, `date`, `product_id`, `qty`, `mrp`, `batch_id`, `expiry_date`, `reason`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(1, 2, '0000-00-00', 4, 1.00, 100.00, 'DEF', '9/19/2020  12:00:00 AM', 'SALES RETURN damage', 'user', '2020-06-19 18:09:30', NULL, NULL);

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
(1, 'TEST COMPANY ', '-  ', '-  ', '9090909090     ', '      ', '      ');

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
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Dumping data for table `stock`
--

INSERT INTO `stock` (`stock_id`, `product_id`, `qty`, `mrp`, `batch_id`, `expiry_date`, `created_by`, `created_on`, `updated_by`, `updated_on`) VALUES
(3, 1, 27, 10.00, 'ABC12', '2020-09-19', 'user', '2020-06-19 17:52:17', 0, '2020-06-19 17:53:31'),
(4, 2, 28, 25.00, 'def23', '2020-09-19', 'user', '2020-06-19 17:52:17', 0, '2020-06-19 17:54:25'),
(1, 3, 3, 1250.00, 'ABC', '2020-09-19', 'user', '2020-06-19 17:50:07', 0, '2020-06-19 18:41:42'),
(2, 4, 11, 100.00, 'DEF', '2020-09-19', 'user', '2020-06-19 17:50:07', 0, '2020-06-19 18:09:30');

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

--
-- Dumping data for table `stock_history`
--

INSERT INTO `stock_history` (`product_id`, `old_qty`, `change_qty`, `current_qty`, `mrp`, `batch_id`, `expiry_date`, `reason`, `created_by`, `created_on`) VALUES
(3, 0, 5, 5, 1250.00, 'ABC', '2020-09-19', 'PURCHASE CREATED FOR NEW BATCH MRP', 'user', '2020-06-19 17:50:07'),
(4, 0, 15, 15, 100.00, 'DEF', '2020-09-19', 'PURCHASE CREATED FOR NEW BATCH MRP', 'user', '2020-06-19 17:50:07'),
(1, 0, 30, 30, 10.00, 'ABC12', '2020-09-19', 'PURCHASE CREATED FOR NEW BATCH MRP', 'user', '2020-06-19 17:52:17'),
(2, 0, 30, 30, 25.00, 'def23', '2020-09-19', 'PURCHASE CREATED FOR NEW BATCH MRP', 'user', '2020-06-19 17:52:17'),
(3, 5, 1, 4, 1250.00, 'ABC', '', 'NEW SALES', 'user', '2020-06-19 17:53:31'),
(1, 30, 3, 27, 10.00, 'ABC12', '', 'NEW SALES', 'user', '2020-06-19 17:53:31'),
(4, 15, 5, 10, 100.00, 'DEF', '', 'NEW SALES', 'user', '2020-06-19 17:54:25'),
(2, 30, 2, 28, 25.00, 'def23', '', 'NEW SALES', 'user', '2020-06-19 17:54:25'),
(4, 10, 1, 11, 100.00, 'DEF', '9/19/2020  12:00:00 AM', 'SALES RETURN ', 'user', '2020-06-19 18:09:30'),
(3, 4, 1, 3, 1250.00, 'ABC', '9/19/2020  12:00:00 AM', 'PURCHASE RETURN ', 'user', '2020-06-19 18:41:42');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
