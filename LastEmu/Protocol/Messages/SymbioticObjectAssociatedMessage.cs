using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class SymbioticObjectAssociatedMessage : NetworkMessage
	{
		public const uint Id = 6527;

		public uint hostUID;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6527;
			}
		}

		public SymbioticObjectAssociatedMessage()
		{
		}

		public SymbioticObjectAssociatedMessage(uint hostUID)
		{
			this.hostUID = hostUID;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.hostUID = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.hostUID);
		}
	}
}