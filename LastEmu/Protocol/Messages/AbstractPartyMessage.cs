using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AbstractPartyMessage : NetworkMessage
	{
		public const uint Id = 6274;

		public uint partyId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6274;
			}
		}

		public AbstractPartyMessage()
		{
		}

		public AbstractPartyMessage(uint partyId)
		{
			this.partyId = partyId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.partyId = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.partyId);
		}
	}
}