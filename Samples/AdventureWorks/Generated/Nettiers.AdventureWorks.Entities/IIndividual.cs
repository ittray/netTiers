﻿using System;
using System.ComponentModel;

namespace Nettiers.AdventureWorks.Entities
{
	/// <summary>
	///		The data structure representation of the 'Individual' table via interface.
	/// </summary>
	/// <remarks>
	/// 	This struct is generated by a tool and should never be modified.
	/// </remarks>
	public interface IIndividual 
	{
		/// <summary>			
		/// CustomerID : Unique customer identification number. Foreign key to Customer.CustomerID.
		/// </summary>
		/// <remarks>Member of the primary key of the underlying table "Individual"</remarks>
		System.Int32 CustomerId { get; set; }
				
		/// <summary>
		/// keep a copy of the original so it can be used for editable primary keys.
		/// </summary>
		System.Int32 OriginalCustomerId { get; set; }
			
		
		
		/// <summary>
		/// ContactID : Identifies the customer in the Contact table. Foreign key to Contact.ContactID.
		/// </summary>
		System.Int32  ContactId  { get; set; }
		
		/// <summary>
		/// Demographics : Personal information such as hobbies, and income collected from online shoppers. Used for sales analysis.
		/// </summary>
		string  Demographics  { get; set; }
		
		/// <summary>
		/// ModifiedDate : Date and time the record was last updated.
		/// </summary>
		System.DateTime  ModifiedDate  { get; set; }
			
		/// <summary>
		/// Creates a new object that is a copy of the current instance.
		/// </summary>
		/// <returns>A new object that is a copy of this instance.</returns>
		System.Object Clone();
		
		#region Data Properties

		#endregion Data Properties

	}
}


