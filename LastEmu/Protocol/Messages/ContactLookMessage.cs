using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ContactLookMessage : NetworkMessage
	{
		public const uint Id = 5934;

		public uint requestId;

		public string playerName;

		public double playerId;

		public EntityLook look;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5934;
			}
		}

		public ContactLookMessage()
		{
		}

		public ContactLookMessage(uint requestId, string playerName, double playerId, EntityLook look)
		{
			this.requestId = requestId;
			this.playerName = playerName;
			this.playerId = playerId;
			this.look = look;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.requestId = reader.ReadVarUhInt();
			this.playerName = reader.ReadUTF();
			this.playerId = reader.ReadVarUhLong();
			this.look = new EntityLook();
			this.look.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)this.requestId);
			writer.WriteUTF(this.playerName);
			writer.WriteVarLong(this.playerId);
			this.look.Serialize(writer);
		}
	}
}