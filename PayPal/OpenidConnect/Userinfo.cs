using System.Collections.Generic;
using PayPal;
using PayPal.Util;

namespace PayPal.OpenidConnect
{
	public class Userinfo
	{
		/// <summary>
		/// Subject - Identifier for the End-User at the Issuer.
		/// </summary>
		private string userIdValue;
	
		public string userId
		{
			get
			{
				return userIdValue;
			}
			set
			{
				userIdValue = value;
			}
		}
		/// <summary>
		/// Subject - Identifier for the End-User at the Issuer.
		/// </summary>
		private string subValue;
	
		public string sub
		{
			get
			{
				return subValue;
			}
			set
			{
				subValue = value;
			}
		}
		/// <summary>
		/// End-User's full name in displayable form including all name parts, possibly including titles and suffixes, ordered according to the End-User's locale and preferences.
		/// </summary>
		private string nameValue;
	
		public string name
		{
			get
			{
				return nameValue;
			}
			set
			{
				nameValue = value;
			}
		}
		/// <summary>
		/// Given name(s) or first name(s) of the End-User
		/// </summary>
		private string givenNameValue;
	
		public string givenName
		{
			get
			{
				return givenNameValue;
			}
			set
			{
				givenNameValue = value;
			}
		}
		/// <summary>
		/// Surname(s) or last name(s) of the End-User.
		/// </summary>
		private string familyNameValue;
	
		public string familyName
		{
			get
			{
				return familyNameValue;
			}
			set
			{
				familyNameValue = value;
			}
		}
		/// <summary>
		/// Middle name(s) of the End-User.
		/// </summary>
		private string middleNameValue;
	
		public string middleName
		{
			get
			{
				return middleNameValue;
			}
			set
			{
				middleNameValue = value;
			}
		}
		/// <summary>
		/// URL of the End-User's profile picture.
		/// </summary>
		private string pictureValue;
	
		public string picture
		{
			get
			{
				return pictureValue;
			}
			set
			{
				pictureValue = value;
			}
		}
		/// <summary>
		/// End-User's preferred e-mail address.
		/// </summary>
		private string emailValue;
	
		public string email
		{
			get
			{
				return emailValue;
			}
			set
			{
				emailValue = value;
			}
		}
		/// <summary>
		/// True if the End-User's e-mail address has been verified; otherwise false.
		/// </summary>
		private bool emailVerifiedValue;
	
		public bool emailVerified
		{
			get
			{
				return emailVerifiedValue;
			}
			set
			{
				emailVerifiedValue = value;
			}
		}
		/// <summary>
		/// End-User's gender.
		/// </summary>
		private string genderValue;
	
		public string gender
		{
			get
			{
				return genderValue;
			}
			set
			{
				genderValue = value;
			}
		}
		/// <summary>
		/// End-User's birthday, represented as an YYYY-MM-DD format. They year MAY be 0000, indicating it is omited. To represent only the year, YYYY format would be used.
		/// </summary>
		private string birthdateValue;
	
		public string birthdate
		{
			get
			{
				return birthdateValue;
			}
			set
			{
				birthdateValue = value;
			}
		}
		/// <summary>
		/// Time zone database representing the End-User's time zone
		/// </summary>
		private string zoneinfoValue;
	
		public string zoneinfo
		{
			get
			{
				return zoneinfoValue;
			}
			set
			{
				zoneinfoValue = value;
			}
		}
		/// <summary>
		/// End-User's locale.
		/// </summary>
		private string localeValue;
	
		public string locale
		{
			get
			{
				return localeValue;
			}
			set
			{
				localeValue = value;
			}
		}
		/// <summary>
		/// End-User's preferred telephone number.
		/// </summary>
		private string phoneNumberValue;
	
		public string phoneNumber
		{
			get
			{
				return phoneNumberValue;
			}
			set
			{
				phoneNumberValue = value;
			}
		}
		/// <summary>
		/// End-User's preferred address.
		/// </summary>
		private Address addressValue;
	
		public Address address
		{
			get
			{
				return addressValue;
			}
			set
			{
				addressValue = value;
			}
		}
		/// <summary>
		/// Verified account status.
		/// </summary>
		private bool verifiedAccountValue;
	
		public bool verifiedAccount
		{
			get
			{
				return verifiedAccountValue;
			}
			set
			{
				verifiedAccountValue = value;
			}
		}
		/// <summary>
		/// Account type.
		/// </summary>
		private string accountTypeValue;
	
		public string accountType
		{
			get
			{
				return accountTypeValue;
			}
			set
			{
				accountTypeValue = value;
			}
		}
		/// <summary>
		/// Account holder age range.
		/// </summary>
		private string ageRangeValue;
	
		public string ageRange
		{
			get
			{
				return ageRangeValue;
			}
			set
			{
				ageRangeValue = value;
			}
		}
		/// <summary>
		/// Account payer identifier.
		/// </summary>
		private string payerIdValue;
	
		public string payerId
		{
			get
			{
				return payerIdValue;
			}
			set
			{
				payerIdValue = value;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public Userinfo()
		{
		
		}
		
	
	/// <summary>
	/// Returns user details
	/// <param name="userinfoParameters">Query parameters used for API call</param>
	/// </summary>
	public static Userinfo GetUserinfo(UserinfoParameters userinfoParameters)
	{
		string pattern = "v1/identity/openidconnect/userinfo?schema={0}&access_token={1}";
		object[] parameters = new object[] { userinfoParameters };
		string resourcePath = SDKUtil.FormatURIPath(pattern, parameters);
		string payLoad = "";
		return PayPalResource.ConfigureAndExecute<Userinfo>(null, HttpMethod.GET,
				resourcePath, null, payLoad);
	}

	/// <summary>
	/// Returns user details
	/// <param name="apiContext">APIContext to be used for the call.</param>
	/// <param name="userinfoParameters">Query parameters used for API call</param>
	/// </summary>
	public static Userinfo GetUserinfo(APIContext apiContext, UserinfoParameters userinfoParameters)
	{
		string pattern = "v1/identity/openidconnect/userinfo?schema={0}&access_token={1}";
		object[] parameters = new object[] { userinfoParameters };
		string resourcePath = SDKUtil.FormatURIPath(pattern, parameters);
		string payLoad = "";
		return PayPalResource.ConfigureAndExecute<Userinfo>(apiContext,
				HttpMethod.GET, resourcePath, null, payLoad);
	}
	}
}

