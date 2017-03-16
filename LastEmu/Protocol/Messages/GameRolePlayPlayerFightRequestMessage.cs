using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameRolePlayPlayerFightRequestMessage : NetworkMessage
	{
		public const uint Id = 5731;

		public double targetId;

		public short targetCellId;

		public bool friendly;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5731;
			}
		}

		public GameRolePlayPlayerFightRequestMessage()
		{
		}

		public GameRolePlayPlayerFightRequestMessage(double targetId, short targetCellId, bool friendly)
		{
			this.targetId = targetId;
			this.targetCellId = targetCellId;
			this.friendly = friendly;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.targetId = reader.ReadVarUhLong();
			this.targetCellId = reader.ReadShort();
			this.friendly = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.targetId);
			writer.WriteShort(this.targetCellId);
			writer.WriteBoolean(this.friendly);
		}
	}
}