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
    /// 实体-TransactionLog 
    /// </summary>
	public partial class TransactionLog
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public long LogId { get; set; }
		
		/// <summary>
		/// 关联编号
		/// </summary>		
		public long? RelationNo { get; set; }
		
		/// <summary>
		/// 类型:1:订单，2：退款，3：转佣
		/// </summary>		
		public int? Type { get; set; }
		
		/// <summary>
		/// 请求内容
		/// </summary>		
		public string RequestContent { get; set; }
		
		/// <summary>
		/// 响应内容
		/// </summary>		
		public string ResponseContent { get; set; }
		
		/// <summary>
		/// 创建时间（入库时间）
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
		/// 是否删除
		/// </summary>		
		public bool IsDelete { get; set; }
		  
    }
}
