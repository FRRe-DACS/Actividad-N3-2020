using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Actividad3_DACS.Models
{
    public class Client
    {
	/// <summary>
	///
	/// </summary>
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int ClientId {get; set; }
	/// <summary>
	///
	/// </summary>
	[Required]
	public string FullName {get; set; }
	/// <summary>
	///
	/// </summary>
	[DataType(DataType.EmailAddress)]
	public string Email { get; set; }
	/// <summary>
	///
	/// </summary>
	[DataType(DataType.PhoneNumber)]
	public string PhoneNumber { get; set; }

    }
}
