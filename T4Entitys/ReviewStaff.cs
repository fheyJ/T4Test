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
    /// 实体-ReviewStaff 
    /// </summary>
	public partial class ReviewStaff
    {
		
		/// <summary>
		/// 系统编号
		/// </summary>		
		public decimal SysNo { get; set; }
		
		/// <summary>
		/// 楼盘编号
		/// </summary>		
		public long BuildingSysNo { get; set; }
		
		/// <summary>
		/// 经纪人编号
		/// </summary>		
		public string StaffNo { get; set; }
		
		/// <summary>
		/// 经纪人名称
		/// </summary>		
		public string StaffName { get; set; }
		
		/// <summary>
		/// 审核等级
		/// </summary>		
		public int ReviewLevel { get; set; }
		
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
