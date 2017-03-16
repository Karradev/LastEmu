using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightInvisibleDetectedMessage : AbstractGameActionMessage
	{
		public const uint Id = 6320;

		public double targetId;

		public short cellId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6320;
			}
		}

		public GameActionFightInvisibleDetectedMessage()
		{
		}

		public GameActionFightInvisibleDetectedMessage(uint actionId, double sourceId, double targetId, short cellId) : base(actionId, sourceId)
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