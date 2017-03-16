using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class HouseGuildShareRequestMessage : NetworkMessage
	{
		public const uint Id = 5704;

		public bool enable;

		public uint rights;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5704;
			}
		}

		public HouseGuildShareRequestMessage()
		{
		}

		public HouseGuildShareRequestMessage(bool enable, uint rights)
		{
			this.enable = enable;
			this.rights = rights;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.enable = reader.ReadBoolean();
			this.rights = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.enable);
			writer.WriteVarInt((int)this.rights);
		}
	}
}