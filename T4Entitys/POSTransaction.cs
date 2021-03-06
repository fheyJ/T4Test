//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//	   生成时间 2016-08-03 13:50:23 by jie
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
namespace T4ConsoleApplication.Entities
{	
    /// <summary>
    /// 实体-POSTransaction 
    /// </summary>
	public partial class POSTransaction
    {
		
		/// <summary>
		/// 系统流水号
		/// </summary>		
		public string SystemSerialNo { get; set; }
		
		/// <summary>
		/// POS流水号
		/// </summary>		
		public string POSSerialNo { get; set; }
		
		/// <summary>
		/// 版本号
		/// </summary>		
		public string VersionNo { get; set; }
		
		/// <summary>
		/// 交易类型：02：普通类型，99：应急类型
		/// </summary>		
		public string TransactionType { get; set; }
		
		/// <summary>
		/// 虚拟单号
		/// </summary>		
		public string VirtualNo { get; set; }
		
		/// <summary>
		/// 支付方式
		/// </summary>		
		public string PayWay { get; set; }
		
		/// <summary>
		/// 订单总金额
		/// </summary>		
		public decimal? OrderTotalMoney { get; set; }
		
		/// <summary>
		/// Post实收金额
		/// </summary>		
		public decimal? OrderRealMoney { get; set; }
		
		/// <summary>
		/// 商户号
		/// </summary>		
		public string MerchantNo { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string POSBatchNo { get; set; }
		
		/// <summary>
		/// 终端号
		/// </summary>		
		public string POSTNo { get; set; }
		
		/// <summary>
		/// 授权号
		/// </summary>		
		public string AuthCode { get; set; }
		
		/// <summary>
		/// 操作员编号
		/// </summary>		
		public string OperationNo { get; set; }
		
		/// <summary>
		/// 订单时间
		/// </summary>		
		public DateTime? OrderTime { get; set; }
		
		/// <summary>
		/// 业务处理时间
		/// </summary>		
		public DateTime? ProcessingTime { get; set; }
		
		/// <summary>
		/// 卡号
		/// </summary>		
		public string BankCardNo { get; set; }
		
		/// <summary>
		/// 返回码
		/// </summary>		
		public string ResponseCode { get; set; }
		
		/// <summary>
		/// 实际单号
		/// </summary>		
		public long? OrderNo { get; set; }
		
		/// <summary>
		/// 发卡方编码
		/// </summary>		
		public string CardCode { get; set; }
		
		/// <summary>
		/// 主机参考号
		/// </summary>		
		public string HostNo { get; set; }
		
		/// <summary>
		/// 创建时间
		/// </summary>		
		public DateTime CreateDate { get; set; }
		
		/// <summary>
		/// 创建人
		/// </summary>		
		public string CreateUserSysNo { get; set; }
		
		/// <summary>
		/// 创建人名称
		/// </summary>		
		public string CreateUserName { get; set; }
		
		/// <summary>
		/// 修改时间
		/// </summary>		
		public DateTime? ModifyDate { get; set; }
		
		/// <summary>
		/// 修改人
		/// </summary>		
		public string ModifyUserSysNo { get; set; }
		
		/// <summary>
		/// 修改人名称
		/// </summary>		
		public string ModifyUserName { get; set; }
		
		/// <summary>
		/// 是否检查
		/// </summary>		
		public bool IsCheck { get; set; }
		
		/// <summary>
		/// 是否删除
		/// </summary>		
		public bool IsDelete { get; set; }
		  
    }
}
