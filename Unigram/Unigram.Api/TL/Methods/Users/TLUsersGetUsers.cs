// <auto-generated/>
using System;

namespace Telegram.Api.TL.Methods.Users
{
	/// <summary>
	/// RCP method users.getUsers
	/// </summary>
	public partial class TLUsersGetUsers : TLObject
	{
		public TLVector<TLInputUserBase> Id { get; set; }

		public TLUsersGetUsers() { }
		public TLUsersGetUsers(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.UsersGetUsers; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Id = TLFactory.Read<TLVector<TLInputUserBase>>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0xD91A548);
			to.WriteObject(Id, cache);
			if (cache) WriteToCache(to);
		}
	}
}