using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StockDatabase.Model
{
    /// <summary>
    /// 采购单
    /// </summary>
    [Table("Purchase")]
    public class Purchase
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        [Key]
        public string OrderId { get; set; }
        /// <summary>
        /// 商品ID
        /// </summary>
        [Required]
        public string GoodsId { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        [Required]
        public string Quantity { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public float Price { get; set; }
        /// <summary>
        /// 供应商ID
        /// </summary>
        public string VendorId { get; set; }
        /// <summary>
        /// 厂家ID
        /// </summary>
        public string ManufacturerId { get; set; }
        /// <summary>
        /// 采购员ID
        /// </summary>
        [Required]
        public string BuyerId { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        [Required]
        public string CreateDate { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        [Required]
        public string CreateById { get; set; }
        /// <summary>
        /// 修改日期
        /// </summary>
        public string UpdateDate { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public string UpdateById { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
