using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
namespace StockDatabase
{
    [Table("Goods")]
    public class Goods
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [Key]
        public string GoodsId { get; set; }
        /// <summary>
        /// 商品编码
        /// </summary>
        [Required]
        public string GoodsCode { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>
        public string PinYinMa { get; set; }
        /// <summary>
        /// 供应商
        /// </summary>
        [Required]
        public string Vendor { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        [Required]
        public string Specifications { get; set; }
        /// <summary>
        /// 条形码
        /// </summary>
        public string BarCode { get; set; }
        /// <summary>
        /// 颜色
        /// </summary>
        public string Color { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 品牌
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// 商品类别
        /// </summary>
        public string Categories { get; set; }
        /// <summary>
        /// 自定义0
        /// </summary>
        public string Custom0 { get; set; }
        /// <summary>
        /// 自定义1
        /// </summary>
        public string Custom1 { get; set; }
        /// <summary>
        /// 自定义2
        /// </summary>
        public string Custom2 { get; set; }
        /// <summary>
        /// 自定义3
        /// </summary>
        public string Custom3 { get; set; }
        /// <summary>
        /// 自定义4
        /// </summary>
        public string Custom4 { get; set; }
        /// <summary>
        /// 自定义5
        /// </summary>
        public string Custom5 { get; set; }
        /// <summary>
        /// 自定义6
        /// </summary>
        public string Custom6 { get; set; }
        /// <summary>
        /// 自定义7
        /// </summary>
        public string Custom7 { get; set; }
        /// <summary>
        /// 自定义8
        /// </summary>
        public string Custom8 { get; set; }
        /// <summary>
        /// 自定义9
        /// </summary>
        public string Custom9 { get; set; }

        public override string ToString()
        {
            return "Goods";
        }

    }
}
