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
    /// 实体-FinanceRuleLog 
    /// </summary>
	public partial class FinanceRuleLog
    {
		
		/// <summary>
		/// 日志Id
		/// </summary>		
		public long LogId { get; set; }
		
		/// <summary>
		/// 关联Id
		/// </summary>		
		public long FinanceRuleSysNo { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string LogInfo { get; set; }
		
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
		/// 是否删除
		/// </summary>		
		public bool IsDelete { get; set; }
		  
    }
}
