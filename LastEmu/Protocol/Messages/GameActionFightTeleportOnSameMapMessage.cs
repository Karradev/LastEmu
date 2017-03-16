using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightTeleportOnSameMapMessage : AbstractGameActionMessage
	{
		public const uint Id = 5528;

		public double targetId;

		public short cellId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5528;
			}
		}

		public GameActionFightTeleportOnSameMapMessage()
		{
		}

		public GameActionFightTeleportOnSameMapMessage(uint actionId, double sourceId, double targetId, short cellId) : base(actionId, sourceId)
		{
			this.targetId = targetId;
			this.cellId = cellId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.targetId = reader.ReadDouble();
			this.cellId = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(this.targetId);
			writer.WriteShort(this.cellId);
		}
	}
}