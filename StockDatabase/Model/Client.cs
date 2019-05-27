using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockDatabase
{
    [Table("Client")]
    public class Client
    {
        /// <summary>
        /// 客户ID
        /// </summary>
        [Key]
        public string ClientId { get; set; }
        /// <summary>
        /// 客户名称
        /// </summary>
        [Required]
        public string ClientName { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>
        public string PinYinMa { get; set; }
        /// <summary>
        /// 公司名称
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// 客户类别
        /// </summary>
        [Required]
        public string ClientType { get; set; }
        /// <summary>
        /// 区域
        /// </summary>
        public string Area { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
        public string Contact { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Mobile { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 传真
        /// </summary>
        public string Fax { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
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
            return "Client";
        }
    }
}
