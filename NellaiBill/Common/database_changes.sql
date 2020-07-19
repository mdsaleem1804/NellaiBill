--truncate table m_supplier;
--truncate table m_patient_registration;
--truncate table m_group;
--truncate table m_product;
--truncate table purchase;
--truncate table purchase_details;
--truncate table purchase_return;
--truncate table sales;
--truncate table sales_details;
--truncate table sales_return;
--truncate table stock_history;
--truncate table stock;
--truncate table outpatientdetails;
--truncate table billing_lab_details;
--truncate table ip_invoice_details;
--truncate table m_doctor;
--truncate table stock_history;
--truncate table billing_scan;
--truncate table billing_lab;
--truncate table billing_ecg_xray;
--truncate table ip_advance_payment;
--truncate table ip_admission;
--truncate table ip_invoice;
--truncate table ip_discharge_entry;
--truncate table backup;

--mysqladmin.exe -u root password secret

-- Table stock has been altered successfully
--ALTER TABLE `stock` ADD `created_by` VARCHAR( 100 ) NOT NULL ,
--ADD `created_on` DATETIME NOT NULL ,
--ADD `updated_by` INT( 100 ) NULL ,
--ADD `updated_on` DATETIME NULL ;

--select p.product_name,c.category_name,g.group_name,s.mrp,s.batch_id,s.expiry_date 
--from stock s ,m_product p ,m_category c,m_group g
--where p.product_id=s.product_id
--and p.group_id=g.group_id
--and g.category_id=c.category_id

--SELECT p.product_id, p.product_name, sh.old_qty, sh.change_qty, sh.current_qty, sh.mrp, sh.batch_id, sh.reason, sh.created_on
--FROM stock s, m_product p, stock_history sh
--WHERE s.product_id = p.product_id
--AND s.product_id = sh.product_id
--AND sh.batch_id = s.batch_id
--AND sh.mrp = s.mrp


--ALTER TABLE `config` ADD `is_m_product_mrp` VARCHAR( 10 ) NOT NULL ;
--ALTER TABLE `m_product` ADD `mrp` DOUBLE( 10, 2 ) NOT NULL AFTER `gst` ;
--UPDATE `hms_lhs`.`config` SET `is_m_product_mrp` = 'YES' WHERE `config`.`config_id` =0;
