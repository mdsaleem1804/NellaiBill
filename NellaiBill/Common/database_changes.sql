ALTER TABLE `config` ADD `is_m_product_mrp` VARCHAR( 10 ) NOT NULL ;
ALTER TABLE `m_product` ADD `mrp` DOUBLE( 10, 2 ) NOT NULL AFTER `gst` ;
UPDATE `hms_lhs`.`config` SET `is_m_product_mrp` = 'YES' WHERE `config`.`config_id` =0;
