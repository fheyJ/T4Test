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
    /// 实体-BankCardCode 
    /// </summary>
	public partial class BankCardCode
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public long SysNo { get; set; }
		
		/// <summary>
		/// 卡号前缀
		/// </summary>		
		public string CardPrefix { get; set; }
		
		/// <summary>
		/// 类型：借，贷
		/// </summary>		
		public string Type { get; set; }
		
		/// <summary>
		/// 卡号长度
		/// </summary>		
		public int? CardNoLength { get; set; }
		
		/// <summary>
		/// 卡详情名称
		/// </summary>		
		public string CardName { get; set; }
		
		/// <summary>
		/// 发卡方编码
		/// </summary>		
		public string CardCode { get; set; }
		
		/// <summary>
		/// 银行名称
		/// </summary>		
		public string BankName { get; set; }
		
		/// <summary>
		/// 卡宾长度
		/// </summary>		
		public int? CardBinLength { get; set; }
		
		/// <summary>
		/// 是否有效
		/// </summary>		
		public bool? IsEffective { get; set; }
		  
    }
}
