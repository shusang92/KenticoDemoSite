//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at https://docs.xperience.io/.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.DemoSite;

[assembly: RegisterDocumentType(Home.CLASS_NAME, typeof(Home))]

namespace CMS.DocumentEngine.Types.DemoSite
{
	/// <summary>
	/// Represents a content item of type Home.
	/// </summary>
	public partial class Home : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "DemoSite.Home";


		/// <summary>
		/// The instance of the class that provides extended API for working with Home fields.
		/// </summary>
		private readonly HomeFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// HomeID.
		/// </summary>
		[DatabaseIDField]
		public int HomeID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("HomeID"), 0);
			}
			set
			{
				SetValue("HomeID", value);
			}
		}


		/// <summary>
		/// text.
		/// </summary>
		[DatabaseField]
		public string HomeHeader
		{
			get
			{
				return ValidationHelper.GetString(GetValue("HomeHeader"), @"");
			}
			set
			{
				SetValue("HomeHeader", value);
			}
		}


		/// <summary>
		/// Text heading.
		/// </summary>
		[DatabaseField]
		public string HomeTextHeading
		{
			get
			{
				return ValidationHelper.GetString(GetValue("HomeTextHeading"), @"");
			}
			set
			{
				SetValue("HomeTextHeading", value);
			}
		}


		/// <summary>
		/// TestText.
		/// </summary>
		[DatabaseField]
		public string TestText
		{
			get
			{
				return ValidationHelper.GetString(GetValue("TestText"), @"");
			}
			set
			{
				SetValue("TestText", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with Home fields.
		/// </summary>
		[RegisterProperty]
		public HomeFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with Home fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class HomeFields : AbstractHierarchicalObject<HomeFields>
		{
			/// <summary>
			/// The content item of type Home that is a target of the extended API.
			/// </summary>
			private readonly Home mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="HomeFields" /> class with the specified content item of type Home.
			/// </summary>
			/// <param name="instance">The content item of type Home that is a target of the extended API.</param>
			public HomeFields(Home instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// HomeID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.HomeID;
				}
				set
				{
					mInstance.HomeID = value;
				}
			}


			/// <summary>
			/// text.
			/// </summary>
			public string Header
			{
				get
				{
					return mInstance.HomeHeader;
				}
				set
				{
					mInstance.HomeHeader = value;
				}
			}


			/// <summary>
			/// Text heading.
			/// </summary>
			public string TextHeading
			{
				get
				{
					return mInstance.HomeTextHeading;
				}
				set
				{
					mInstance.HomeTextHeading = value;
				}
			}


			/// <summary>
			/// TestText.
			/// </summary>
			public string TestText
			{
				get
				{
					return mInstance.TestText;
				}
				set
				{
					mInstance.TestText = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="Home" /> class.
		/// </summary>
		public Home() : base(CLASS_NAME)
		{
			mFields = new HomeFields(this);
		}

		#endregion
	}
}