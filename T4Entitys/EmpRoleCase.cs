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
    /// 实体-EmpRoleCase 
    /// </summary>
	public partial class EmpRoleCase
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public string MD5 { get; set; }
		
		/// <summary>
		/// 员工编号
		/// </summary>		
		public long EmpSysNo { get; set; }
		
		/// <summary>
		/// 角色编号
		/// </summary>		
		public long RoleSysNo { get; set; }
		
		/// <summary>
		/// 负责标记(0:否;1:是)
		/// </summary>		
		public bool IsResponsible { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public long? CreateUserSysNo { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? CreateDate { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public long? ModifyUserSysNo { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public DateTime? ModifyDate { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public bool IsDelete { get; set; }
		  
    }
}
