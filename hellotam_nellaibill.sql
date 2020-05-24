-- phpMyAdmin SQL Dump
-- version 4.9.4
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: May 17, 2020 at 05:24 AM
-- Server version: 5.6.47-cll-lve
-- PHP Version: 7.3.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `nellaibill`
--

-- --------------------------------------------------------

--
-- Table structure for table `accounts_credit_note`
--

CREATE TABLE `accounts_credit_note` (
  `accounts_credit_note_id` int(11) NOT NULL,
  `ledger_no` int(11) NOT NULL,
  `credit_note_date` date NOT NULL,
  `itemno` int(11) NOT NULL,
  `qty` int(5) NOT NULL,
  `details` varchar(250) NOT NULL,
  `created_as_on` datetime NOT NULL,
  `updated_as_on` datetime NOT NULL,
  `logged_user` varchar(50) NOT NULL,
  `batchid` varchar(25) NOT NULL,
  `expdate` date NOT NULL,
  `mrp` double(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `accounts_debit_note`
--

CREATE TABLE `accounts_debit_note` (
  `accounts_debit_note_id` int(11) NOT NULL,
  `ledger_no` int(11) NOT NULL,
  `debit_note_date` date NOT NULL,
  `itemno` int(11) NOT NULL,
  `qty` double(10,2) NOT NULL,
  `details` varchar(250) NOT NULL,
  `created_as_on` datetime NOT NULL,
  `updated_as_on` datetime NOT NULL,
  `logged_user` varchar(50) NOT NULL,
  `batchid` varchar(25) NOT NULL,
  `dateexpired` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `accounts_payment`
--

CREATE TABLE `accounts_payment` (
  `accounts_payment_id` int(11) NOT NULL,
  `accounts_payment_date` date NOT NULL,
  `accounts_payment_ledger_id` int(5) NOT NULL,
  `accounts_payment_amount` double(10,2) NOT NULL,
  `accounts_payment_remarks` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `accounts_receipt`
--

CREATE TABLE `accounts_receipt` (
  `accounts_receipt_id` int(11) NOT NULL,
  `accounts_receipt_date` date NOT NULL,
  `accounts_receipt_ledger_id` int(5) NOT NULL,
  `accounts_receipt_amount` double(10,2) NOT NULL,
  `accounts_receipt_remarks` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `account_group`
--

CREATE TABLE `account_group` (
  `account_group_id` int(11) NOT NULL,
  `account_group_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `account_ledger`
--

CREATE TABLE `account_ledger` (
  `account_ledger_id` int(11) NOT NULL,
  `ledger_name` varchar(100) DEFAULT NULL,
  `ledger_alias_name` varchar(100) NOT NULL,
  `ledger_undergroup_no` int(11) NOT NULL,
  `ledger_address` varchar(250) NOT NULL,
  `ledger_mobile_no` varchar(50) NOT NULL,
  `ledger_unique_no` varchar(50) NOT NULL,
  `credit_limit` double(10,2) NOT NULL,
  `opening_balance` double(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `account_ledger`
--

INSERT INTO `account_ledger` (`account_ledger_id`, `ledger_name`, `ledger_alias_name`, `ledger_undergroup_no`, `ledger_address`, `ledger_mobile_no`, `ledger_unique_no`, `credit_limit`, `opening_balance`) VALUES
(1, 'saleem', '', 5, '', '', '', 0.00, 0.00);

-- --------------------------------------------------------

--
-- Table structure for table `audit_stock`
--

CREATE TABLE `audit_stock` (
  `audit_stock_itemno` int(5) NOT NULL,
  `audit_stock_qty` int(5) NOT NULL,
  `audit_stock_datetime` datetime NOT NULL,
  `audit_stock_mode` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `audit_stock`
--

INSERT INTO `audit_stock` (`audit_stock_itemno`, `audit_stock_qty`, `audit_stock_datetime`, `audit_stock_mode`) VALUES
(1, 100, '2020-05-17 03:18:30', 'INSERT'),
(1, 99, '2020-05-17 03:23:46', 'UPDATE');

-- --------------------------------------------------------

--
-- Table structure for table `backup`
--

CREATE TABLE `backup` (
  `id` int(5) NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `backup`
--

INSERT INTO `backup` (`id`, `date`) VALUES
(1, '2019-04-06'),
(2, '2019-04-11'),
(3, '2019-05-18'),
(4, '2019-05-19'),
(5, '2019-05-20'),
(6, '2019-05-21'),
(7, '2019-05-22');

-- --------------------------------------------------------

--
-- Table structure for table `config_inventory`
--

CREATE TABLE `config_inventory` (
  `categoryno` int(3) NOT NULL,
  `groupno` int(3) NOT NULL,
  `subgroupno` int(3) NOT NULL,
  `stockpointno` int(3) NOT NULL,
  `supplierno` int(3) NOT NULL,
  `customerno` int(5) NOT NULL,
  `itemno` int(5) NOT NULL,
  `fromdate` date NOT NULL,
  `todate` date NOT NULL,
  `temppurchaseqty` int(5) NOT NULL,
  `tempsalesqty` int(5) NOT NULL,
  `print_template` varchar(100) NOT NULL,
  `purchase_invoice_no` int(11) NOT NULL,
  `sales_invoice_no` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `config_inventory`
--

INSERT INTO `config_inventory` (`categoryno`, `groupno`, `subgroupno`, `stockpointno`, `supplierno`, `customerno`, `itemno`, `fromdate`, `todate`, `temppurchaseqty`, `tempsalesqty`, `print_template`, `purchase_invoice_no`, `sales_invoice_no`) VALUES
(1, 1, 1, 1, 4, 5, 1, '2018-01-01', '2019-03-31', 0, 0, 'print_format8.php', 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `config_item`
--

CREATE TABLE `config_item` (
  `config_item_id` int(1) NOT NULL,
  `itemno` varchar(5) NOT NULL,
  `itemdescription` varchar(5) NOT NULL,
  `hsncode` varchar(5) NOT NULL,
  `gst` varchar(5) NOT NULL,
  `rack` varchar(5) NOT NULL,
  `row` varchar(5) NOT NULL,
  `minstock` varchar(5) NOT NULL,
  `stockpoint` varchar(5) NOT NULL,
  `group` varchar(5) NOT NULL,
  `packno` varchar(5) NOT NULL,
  `packdescription` varchar(5) NOT NULL,
  `barcode` varchar(3) NOT NULL,
  `color` varchar(3) NOT NULL,
  `size` varchar(3) NOT NULL,
  `originalprice` varchar(3) NOT NULL,
  `mrp` varchar(3) NOT NULL,
  `disamount` varchar(3) NOT NULL,
  `supplierno` varchar(3) NOT NULL,
  `typetamil` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `config_item`
--

INSERT INTO `config_item` (`config_item_id`, `itemno`, `itemdescription`, `hsncode`, `gst`, `rack`, `row`, `minstock`, `stockpoint`, `group`, `packno`, `packdescription`, `barcode`, `color`, `size`, `originalprice`, `mrp`, `disamount`, `supplierno`, `typetamil`) VALUES
(1, 'Yes', 'No', 'Yes', 'Yes', 'Yes', 'Yes', 'No', 'No', 'Yes', 'Yes', 'Yes', 'No', 'No', 'No', 'No', 'No', 'No', 'No', 'No');

-- --------------------------------------------------------

--
-- Table structure for table `config_purchase`
--

CREATE TABLE `config_purchase` (
  `config_purchase_id` int(3) NOT NULL,
  `config_purchase_invoiceno` varchar(5) NOT NULL,
  `config_purchase_batch` varchar(5) NOT NULL,
  `config_purchase_expiry` varchar(5) NOT NULL,
  `config_purchase_discount` varchar(5) NOT NULL,
  `config_purchase_gst` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `config_purchase`
--

INSERT INTO `config_purchase` (`config_purchase_id`, `config_purchase_invoiceno`, `config_purchase_batch`, `config_purchase_expiry`, `config_purchase_discount`, `config_purchase_gst`) VALUES
(1, 'No', 'Yes', 'Yes', 'Yes', 'No');

-- --------------------------------------------------------

--
-- Table structure for table `config_quotation`
--

CREATE TABLE `config_quotation` (
  `id` int(3) NOT NULL,
  `line1` varchar(250) NOT NULL,
  `line2` varchar(250) NOT NULL,
  `line3` varchar(250) NOT NULL,
  `line4` varchar(250) NOT NULL,
  `line5` varchar(250) NOT NULL,
  `line6` varchar(250) NOT NULL,
  `line7` varchar(250) NOT NULL,
  `line8` varchar(250) NOT NULL,
  `line9` varchar(250) NOT NULL,
  `line10` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `config_quotation`
--

INSERT INTO `config_quotation` (`id`, `line1`, `line2`, `line3`, `line4`, `line5`, `line6`, `line7`, `line8`, `line9`, `line10`) VALUES
(1, 'TE Q- 123', 'Supply and Installation of HIK Vision AHD system.', 'Dear Sir,', 'With Reference to the above Subject,we are pleased to quote our best price for supply,installation and testing of HIK vision AHD CCTV system as per following terms.', '30 Days', '1 Year Free', '1 Year Against Manufacturing Defect', '75 % Advance(Remaining 25 % Against Completion)', 'i', 'j');

-- --------------------------------------------------------

--
-- Table structure for table `config_sales`
--

CREATE TABLE `config_sales` (
  `config_sales_id` int(3) NOT NULL,
  `invoiceno` varchar(10) NOT NULL,
  `stock` varchar(10) NOT NULL,
  `gst` varchar(10) NOT NULL,
  `discount` varchar(10) NOT NULL,
  `salesperson` varchar(10) NOT NULL,
  `despatch` varchar(10) NOT NULL,
  `destination` varchar(10) NOT NULL,
  `delivery` varchar(10) NOT NULL,
  `vehicleno` varchar(10) NOT NULL,
  `service` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `config_sales`
--

INSERT INTO `config_sales` (`config_sales_id`, `invoiceno`, `stock`, `gst`, `discount`, `salesperson`, `despatch`, `destination`, `delivery`, `vehicleno`, `service`) VALUES
(1, 'No', 'Yes', 'Yes', 'No', 'Yes', 'No', 'No', 'Yes', 'No', 'No');

-- --------------------------------------------------------

--
-- Table structure for table `fmcg_doctor`
--

CREATE TABLE `fmcg_doctor` (
  `doctorno` int(3) NOT NULL,
  `doctorname` varchar(50) NOT NULL,
  `specialist` varchar(50) NOT NULL,
  `status` varchar(25) NOT NULL,
  `mobileno` bigint(10) NOT NULL,
  `address` varchar(200) NOT NULL,
  `color` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `fmcg_doctor`
--

INSERT INTO `fmcg_doctor` (`doctorno`, `doctorname`, `specialist`, `status`, `mobileno`, `address`, `color`) VALUES
(1, 'Dr. R. Srinivasan', '', 'FAMILY', 0, '', '#000000');

-- --------------------------------------------------------

--
-- Table structure for table `inv_estimateentry`
--

CREATE TABLE `inv_estimateentry` (
  `estimate_txno` int(5) NOT NULL,
  `estimate_id` int(5) NOT NULL,
  `estimate_date` date NOT NULL,
  `itemno` int(5) NOT NULL,
  `qty` int(5) NOT NULL,
  `amount` double(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `inv_estimateentry1`
--

CREATE TABLE `inv_estimateentry1` (
  `estimate_id` int(5) NOT NULL,
  `estimate_date` date NOT NULL,
  `estimate_customerno` int(3) NOT NULL,
  `estimate_totalamount` double(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `inv_purchaseentry`
--

CREATE TABLE `inv_purchaseentry` (
  `txno` int(11) NOT NULL,
  `purchaseinvoiceno` int(10) NOT NULL,
  `itemno` int(5) NOT NULL,
  `purchasedescription` varchar(250) NOT NULL,
  `dateexpired` date NOT NULL,
  `batchid` varchar(25) NOT NULL,
  `qty` int(6) NOT NULL,
  `freeqty` int(5) NOT NULL,
  `packno` int(5) NOT NULL,
  `currentqty` double(10,2) NOT NULL,
  `originalprice` decimal(10,2) NOT NULL,
  `sellingprice` decimal(10,2) NOT NULL,
  `discount` decimal(10,2) NOT NULL,
  `vat` decimal(10,2) NOT NULL,
  `total` decimal(10,2) NOT NULL,
  `nettotal` decimal(10,2) NOT NULL,
  `profit` decimal(10,2) NOT NULL,
  `date` date NOT NULL,
  `createdason` datetime NOT NULL,
  `updatedason` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `inv_purchaseentry1`
--

CREATE TABLE `inv_purchaseentry1` (
  `purchaseinvoiceno` int(5) NOT NULL,
  `supplierno` int(5) NOT NULL,
  `companyinvoiceno` varchar(15) NOT NULL,
  `totalamount` double(10,2) NOT NULL,
  `date` date NOT NULL,
  `freight` double(10,2) NOT NULL,
  `others` double(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `inv_purchase_return`
--

CREATE TABLE `inv_purchase_return` (
  `returndate` date NOT NULL,
  `itemno` int(5) NOT NULL,
  `inv_no` int(5) NOT NULL,
  `return_qty` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `inv_salesentry`
--

CREATE TABLE `inv_salesentry` (
  `txno` int(11) NOT NULL,
  `salesinvoiceno` int(6) NOT NULL,
  `purchaseinvoiceno` int(5) NOT NULL,
  `purchaseinvoicetxno` int(5) NOT NULL,
  `date` date NOT NULL,
  `customerno` int(5) NOT NULL,
  `itemno` int(5) NOT NULL,
  `batchid` varchar(100) NOT NULL,
  `dateexpired` date NOT NULL,
  `qty` int(6) NOT NULL,
  `unitrate` double(10,2) NOT NULL,
  `amount` double(10,2) NOT NULL,
  `vat` double(5,2) NOT NULL,
  `discountpercentage` double(10,2) NOT NULL,
  `usagestockpointno` int(3) NOT NULL,
  `usagestockdetails` varchar(100) NOT NULL,
  `createdason` datetime NOT NULL,
  `updatedason` datetime NOT NULL,
  `unitmrp` double(10,2) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `inv_salesentry`
--

INSERT INTO `inv_salesentry` (`txno`, `salesinvoiceno`, `purchaseinvoiceno`, `purchaseinvoicetxno`, `date`, `customerno`, `itemno`, `batchid`, `dateexpired`, `qty`, `unitrate`, `amount`, `vat`, `discountpercentage`, `usagestockpointno`, `usagestockdetails`, `createdason`, `updatedason`, `unitmrp`) VALUES
(5, 1, 0, 0, '2020-05-17', 1, 1, 'OS', '2020-05-17', 1, 12.00, 0.00, 5.00, 10.00, 0, '', '2020-05-17 12:53:49', '2020-05-17 12:53:49', 12.60);

-- --------------------------------------------------------

--
-- Table structure for table `inv_salesentry1`
--

CREATE TABLE `inv_salesentry1` (
  `salesinvoiceno` int(5) NOT NULL,
  `date` date NOT NULL,
  `customerno` int(5) NOT NULL,
  `totalamount` double(10,2) NOT NULL,
  `lessamount` double(10,2) NOT NULL,
  `despatch` varchar(100) NOT NULL,
  `destination` varchar(100) NOT NULL,
  `modeofpayment` varchar(50) NOT NULL,
  `termsofdelivery` varchar(200) NOT NULL,
  `vehicleno` varchar(100) NOT NULL,
  `servicecharges` varchar(100) NOT NULL,
  `salesperson_id` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `inv_salesentry1`
--

INSERT INTO `inv_salesentry1` (`salesinvoiceno`, `date`, `customerno`, `totalamount`, `lessamount`, `despatch`, `destination`, `modeofpayment`, `termsofdelivery`, `vehicleno`, `servicecharges`, `salesperson_id`) VALUES
(1, '2020-05-17', 1, 13.20, 1.20, '', '', 'Cash', 'IP', '', '', '0');

-- --------------------------------------------------------

--
-- Table structure for table `inv_sales_return`
--

CREATE TABLE `inv_sales_return` (
  `returndate` date NOT NULL,
  `itemno` int(5) NOT NULL,
  `inv_no` int(5) NOT NULL,
  `return_qty` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `inv_stockentry`
--

CREATE TABLE `inv_stockentry` (
  `stockno` int(5) NOT NULL,
  `itemno` int(5) NOT NULL,
  `stock` int(6) NOT NULL,
  `minstock` int(5) NOT NULL,
  `maxstock` int(5) NOT NULL,
  `mrp` double(10,2) NOT NULL,
  `batch` varchar(50) NOT NULL,
  `expdate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `inv_stockentry`
--

INSERT INTO `inv_stockentry` (`stockno`, `itemno`, `stock`, `minstock`, `maxstock`, `mrp`, `batch`, `expdate`) VALUES
(1, 1, 99, 0, 0, 12.00, 'OS', '2020-05-17');

--
-- Triggers `inv_stockentry`
--
DELIMITER $$
CREATE TRIGGER `trig_audit_stock_delete` AFTER DELETE ON `inv_stockentry` FOR EACH ROW insert into 
audit_stock(audit_stock_itemno,
            audit_stock_qty,
            audit_stock_datetime,
            audit_stock_mode)
VALUES(OLD.itemno,OLD.stock,NOW(),"DELETE")
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `trig_audit_stock_insert` AFTER INSERT ON `inv_stockentry` FOR EACH ROW insert into 
audit_stock(audit_stock_itemno,
            audit_stock_qty,
            audit_stock_datetime,
            audit_stock_mode)
VALUES(NEW.itemno,NEW.stock,NOW(),"INSERT")
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `trig_audit_stock_update` AFTER UPDATE ON `inv_stockentry` FOR EACH ROW insert into 
audit_stock(audit_stock_itemno,
            audit_stock_qty,
            audit_stock_datetime,
            audit_stock_mode)
VALUES(NEW.itemno,NEW.stock,NOW(),"UPDATE")
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `m_item`
--

CREATE TABLE `m_item` (
  `itemno` int(5) NOT NULL,
  `stockpointno` int(5) NOT NULL,
  `itemcategoryno` int(5) NOT NULL,
  `itemgroupno` int(5) NOT NULL,
  `itemsubgroupno` int(5) NOT NULL,
  `itemname` varchar(250) NOT NULL,
  `itemdescription` longtext NOT NULL,
  `hsncode` varchar(50) NOT NULL,
  `packno` int(6) NOT NULL,
  `packdescription` varchar(100) NOT NULL,
  `gst` varchar(25) NOT NULL,
  `rackname` varchar(50) NOT NULL,
  `rowname` varchar(50) NOT NULL,
  `minstock` int(5) NOT NULL,
  `barcode` varchar(100) NOT NULL,
  `color` varchar(100) NOT NULL,
  `size` varchar(100) NOT NULL,
  `originalprice` double(10,2) NOT NULL,
  `mrp` double(10,2) NOT NULL,
  `disamount` double(10,2) NOT NULL,
  `supplierno` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `m_item`
--

INSERT INTO `m_item` (`itemno`, `stockpointno`, `itemcategoryno`, `itemgroupno`, `itemsubgroupno`, `itemname`, `itemdescription`, `hsncode`, `packno`, `packdescription`, `gst`, `rackname`, `rowname`, `minstock`, `barcode`, `color`, `size`, `originalprice`, `mrp`, `disamount`, `supplierno`) VALUES
(1, 1, 28, 0, 0, 'item', '', '123', 0, '', '1', '', '', 0, '', '', '', 0.00, 12.00, 0.00, 0);

-- --------------------------------------------------------

--
-- Table structure for table `m_itemcategory`
--

CREATE TABLE `m_itemcategory` (
  `itemcategoryno` int(3) NOT NULL,
  `itemcategoryname` varchar(100) NOT NULL,
  `itemcategoryshortname` varchar(20) NOT NULL,
  `itemcategorycolor` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `m_itemcategory`
--

INSERT INTO `m_itemcategory` (`itemcategoryno`, `itemcategoryname`, `itemcategoryshortname`, `itemcategorycolor`) VALUES
(28, 'CATEGORY', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `m_itemgroup`
--

CREATE TABLE `m_itemgroup` (
  `itemgroupno` int(3) NOT NULL,
  `itemcategoryno` int(3) NOT NULL,
  `itemgroupname` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `m_itemgroup`
--

INSERT INTO `m_itemgroup` (`itemgroupno`, `itemcategoryno`, `itemgroupname`) VALUES
(0, 28, 'GROUP');

-- --------------------------------------------------------

--
-- Table structure for table `m_itemsubgroup`
--

CREATE TABLE `m_itemsubgroup` (
  `itemsubgroupno` int(5) NOT NULL,
  `itemgroupno` int(5) NOT NULL,
  `itemsubgroupname` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `m_login`
--

CREATE TABLE `m_login` (
  `userno` int(3) NOT NULL,
  `username` varchar(25) NOT NULL,
  `password` varchar(100) NOT NULL,
  `departmentno` int(3) NOT NULL,
  `role` varchar(25) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `m_login`
--

INSERT INTO `m_login` (`userno`, `username`, `password`, `departmentno`, `role`) VALUES
(1, 'user', 'user', 1, 'u'),
(2, 'KOWSI', 'MURUGAN', 1, 'U'),
(3, 'MAHA', 'MAHA', 1, 'U'),
(4, 'BALA', 'BALA', 1, 'U'),
(5, 'ACCOUNTS', 'SARA1974', 1, 'A'),
(6, 'ADMIN', 'ADMIN123', 1, 'A'),
(7, 'SANKARI', 'SANKARI', 1, 'U');

-- --------------------------------------------------------

--
-- Table structure for table `m_openingstock`
--

CREATE TABLE `m_openingstock` (
  `openingstockno` int(5) NOT NULL,
  `itemno` int(5) NOT NULL,
  `qty` int(6) NOT NULL,
  `mrp` double(10,2) NOT NULL,
  `batch` varchar(50) NOT NULL,
  `expdate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `m_tax`
--

CREATE TABLE `m_tax` (
  `tax_no` int(3) NOT NULL,
  `tax_name` varchar(20) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `m_tax`
--

INSERT INTO `m_tax` (`tax_no`, `tax_name`) VALUES
(1, '5'),
(2, '12');

-- --------------------------------------------------------

--
-- Table structure for table `m_unit`
--

CREATE TABLE `m_unit` (
  `unit_no` int(5) NOT NULL,
  `unit_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `m_unit`
--

INSERT INTO `m_unit` (`unit_no`, `unit_name`) VALUES
(1, 'Pcs'),
(2, 'Stripes');

-- --------------------------------------------------------

--
-- Table structure for table `stock_history`
--

CREATE TABLE `stock_history` (
  `stock_history_id` int(3) NOT NULL,
  `itemno` int(3) NOT NULL,
  `category` int(3) NOT NULL,
  `qty` int(3) NOT NULL,
  `remarks` varchar(50) NOT NULL,
  `created_at` datetime NOT NULL,
  `created_by` varchar(100) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `stock_history`
--

INSERT INTO `stock_history` (`stock_history_id`, `itemno`, `category`, `qty`, `remarks`, `created_at`, `created_by`) VALUES
(1, 1, 0, 100, 'NEW ITEM CREATED', '0000-00-00 00:00:00', ''),
(2, 1, 0, 1, 'NEW SALES CREATED', '0000-00-00 00:00:00', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accounts_credit_note`
--
ALTER TABLE `accounts_credit_note`
  ADD PRIMARY KEY (`accounts_credit_note_id`);

--
-- Indexes for table `accounts_debit_note`
--
ALTER TABLE `accounts_debit_note`
  ADD PRIMARY KEY (`accounts_debit_note_id`);

--
-- Indexes for table `accounts_payment`
--
ALTER TABLE `accounts_payment`
  ADD PRIMARY KEY (`accounts_payment_id`);

--
-- Indexes for table `accounts_receipt`
--
ALTER TABLE `accounts_receipt`
  ADD PRIMARY KEY (`accounts_receipt_id`);

--
-- Indexes for table `account_ledger`
--
ALTER TABLE `account_ledger`
  ADD PRIMARY KEY (`account_ledger_id`),
  ADD UNIQUE KEY `ledger_name` (`ledger_name`);

--
-- Indexes for table `backup`
--
ALTER TABLE `backup`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `config_item`
--
ALTER TABLE `config_item`
  ADD PRIMARY KEY (`config_item_id`);

--
-- Indexes for table `config_purchase`
--
ALTER TABLE `config_purchase`
  ADD PRIMARY KEY (`config_purchase_id`);

--
-- Indexes for table `config_quotation`
--
ALTER TABLE `config_quotation`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `config_sales`
--
ALTER TABLE `config_sales`
  ADD PRIMARY KEY (`config_sales_id`);

--
-- Indexes for table `fmcg_doctor`
--
ALTER TABLE `fmcg_doctor`
  ADD PRIMARY KEY (`doctorno`),
  ADD KEY `doctorno` (`doctorno`);

--
-- Indexes for table `inv_estimateentry`
--
ALTER TABLE `inv_estimateentry`
  ADD PRIMARY KEY (`estimate_txno`);

--
-- Indexes for table `inv_estimateentry1`
--
ALTER TABLE `inv_estimateentry1`
  ADD PRIMARY KEY (`estimate_id`);

--
-- Indexes for table `inv_purchaseentry`
--
ALTER TABLE `inv_purchaseentry`
  ADD PRIMARY KEY (`txno`),
  ADD KEY `itemno` (`itemno`);

--
-- Indexes for table `inv_purchaseentry1`
--
ALTER TABLE `inv_purchaseentry1`
  ADD PRIMARY KEY (`purchaseinvoiceno`),
  ADD KEY `supplierno` (`supplierno`),
  ADD KEY `supplierno_2` (`supplierno`);

--
-- Indexes for table `inv_salesentry`
--
ALTER TABLE `inv_salesentry`
  ADD PRIMARY KEY (`txno`,`salesinvoiceno`),
  ADD KEY `usagestockpointno` (`usagestockpointno`),
  ADD KEY `customerno` (`customerno`);

--
-- Indexes for table `inv_salesentry1`
--
ALTER TABLE `inv_salesentry1`
  ADD PRIMARY KEY (`salesinvoiceno`),
  ADD KEY `customerno` (`customerno`);

--
-- Indexes for table `inv_stockentry`
--
ALTER TABLE `inv_stockentry`
  ADD PRIMARY KEY (`stockno`);

--
-- Indexes for table `m_item`
--
ALTER TABLE `m_item`
  ADD PRIMARY KEY (`itemno`),
  ADD UNIQUE KEY `itemname` (`itemname`),
  ADD KEY `stockpointno` (`stockpointno`);

--
-- Indexes for table `m_itemcategory`
--
ALTER TABLE `m_itemcategory`
  ADD PRIMARY KEY (`itemcategoryno`),
  ADD UNIQUE KEY `itemcategoryname` (`itemcategoryname`),
  ADD KEY `itemcategoryno` (`itemcategoryno`),
  ADD KEY `itemcategoryno_2` (`itemcategoryno`),
  ADD KEY `itemcategoryno_3` (`itemcategoryno`),
  ADD KEY `itemcategoryno_4` (`itemcategoryno`),
  ADD KEY `itemcategoryno_5` (`itemcategoryno`);

--
-- Indexes for table `m_itemgroup`
--
ALTER TABLE `m_itemgroup`
  ADD PRIMARY KEY (`itemgroupno`),
  ADD UNIQUE KEY `itemgroupname` (`itemgroupname`),
  ADD KEY `itemgroupno` (`itemgroupno`),
  ADD KEY `itemgroupno_2` (`itemgroupno`),
  ADD KEY `itemcategoryno` (`itemcategoryno`),
  ADD KEY `itemcategoryno_2` (`itemcategoryno`);

--
-- Indexes for table `m_itemsubgroup`
--
ALTER TABLE `m_itemsubgroup`
  ADD PRIMARY KEY (`itemsubgroupno`),
  ADD KEY `itemgroupno` (`itemgroupno`);

--
-- Indexes for table `m_login`
--
ALTER TABLE `m_login`
  ADD PRIMARY KEY (`username`);

--
-- Indexes for table `m_openingstock`
--
ALTER TABLE `m_openingstock`
  ADD PRIMARY KEY (`openingstockno`);

--
-- Indexes for table `stock_history`
--
ALTER TABLE `stock_history`
  ADD PRIMARY KEY (`stock_history_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accounts_payment`
--
ALTER TABLE `accounts_payment`
  MODIFY `accounts_payment_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `accounts_receipt`
--
ALTER TABLE `accounts_receipt`
  MODIFY `accounts_receipt_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `backup`
--
ALTER TABLE `backup`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `inv_purchaseentry`
--
ALTER TABLE `inv_purchaseentry`
  MODIFY `txno` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `inv_salesentry`
--
ALTER TABLE `inv_salesentry`
  MODIFY `txno` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `inv_stockentry`
--
ALTER TABLE `inv_stockentry`
  MODIFY `stockno` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `m_itemcategory`
--
ALTER TABLE `m_itemcategory`
  MODIFY `itemcategoryno` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;

--
-- AUTO_INCREMENT for table `stock_history`
--
ALTER TABLE `stock_history`
  MODIFY `stock_history_id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
