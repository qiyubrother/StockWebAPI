using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockDatabase.Model
{
    /// <summary>
    /// 存储到仓库
    /// </summary>
    [Table("Save")]
    public class Save
    {
        /// <summary>
        /// 提货单ID
        /// </summary>
        [Key]
        public string SaveId { get; set; }
        /// <summary>
        /// 订单ID
        /// </summary>
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
        /// 仓库ID
        /// </summary>
        public string WarehouseId { get; set; }
        /// <summary>
        /// 仓位ID
        /// </summary>
        public string LocationId { get; set; }
        /// <summary>
        /// 入库人ID
        /// </summary>
        [Required]
        public string SaveById { get; set; }
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
