// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Messages.Methods
{
	/// <summary>
	/// RCP method messages.toggleDialogPin.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLMessagesToggleDialogPin : TLObject
	{
		[Flags]
		public enum Flag : Int32
		{
			Pinned = (1 << 0),
		}

		public bool IsPinned { get { return Flags.HasFlag(Flag.Pinned); } set { Flags = value ? (Flags | Flag.Pinned) : (Flags & ~Flag.Pinned); } }

		public Flag Flags { get; set; }
		public TLInputPeerBase Peer { get; set; }

		public TLMessagesToggleDialogPin() { }
		public TLMessagesToggleDialogPin(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesToggleDialogPin; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Peer = TLFactory.Read<TLInputPeerBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32((Int32)Flags);
			to.WriteObject(Peer);
		}
	}
}