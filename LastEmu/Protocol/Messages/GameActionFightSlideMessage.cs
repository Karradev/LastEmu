using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightSlideMessage : AbstractGameActionMessage
	{
		public const uint Id = 5525;

		public double targetId;

		public short startCellId;

		public short endCellId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5525;
			}
		}

		public GameActionFightSlideMessage()
		{
		}

		public GameActionFightSlideMessage(uint actionId, double sourceId, double targetId, short startCellId, short endCellId) : base(actionId, sourceId)
		{
			this.targetId = targetId;
			this.startCellId = startCellId;
			this.endCellId = endCellId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.targetId = reader.ReadDouble();
			this.startCellId = reader.ReadShort();
			this.endCellId = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(this.targetId);
			writer.WriteShort(this.startCellId);
			writer.WriteShort(this.endCellId);
		}
	}
}