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
    /// 实体-RoleDepartment 
    /// </summary>
	public partial class RoleDepartment
    {
		
		/// <summary>
		/// 
		/// </summary>		
		public string MD5 { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public long RoleSysNo { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public string DepartmentNo { get; set; }
		
		/// <summary>
		/// 创建者
		/// </summary>		
		public string CreateUserSysNo { get; set; }
		
		/// <summary>
		/// 创建时间
		/// </summary>		
		public DateTime? CreateDate { get; set; }
		
		/// <summary>
		/// 修改者
		/// </summary>		
		public string ModifyUserSysNo { get; set; }
		
		/// <summary>
		/// 修改时间
		/// </summary>		
		public DateTime? ModifyDate { get; set; }
		
		/// <summary>
		/// 
		/// </summary>		
		public long ParentSysNo { get; set; }
		  
    }
}
