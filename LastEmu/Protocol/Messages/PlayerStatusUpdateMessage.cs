using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class PlayerStatusUpdateMessage : NetworkMessage
	{
		public const uint Id = 6386;

		public int accountId;

		public double playerId;

		public PlayerStatus status;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6386;
			}
		}

		public PlayerStatusUpdateMessage()
		{
		}

		public PlayerStatusUpdateMessage(int accountId, double playerId, PlayerStatus status)
		{
			this.accountId = accountId;
			this.playerId = playerId;
			this.status = status;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.accountId = reader.ReadInt();
			this.playerId = reader.ReadVarUhLong();
			this.status = ProtocolTypeManager.GetInstance<PlayerStatus>(reader.ReadUShort());
			this.status.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.accountId);
			writer.WriteVarLong(this.playerId);
			writer.WriteShort(this.status.TypeId);
			this.status.Serialize(writer);
		}
	}
}