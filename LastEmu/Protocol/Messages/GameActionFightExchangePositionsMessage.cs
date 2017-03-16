using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightExchangePositionsMessage : AbstractGameActionMessage
	{
		public const uint Id = 5527;

		public double targetId;

		public short casterCellId;

		public short targetCellId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5527;
			}
		}

		public GameActionFightExchangePositionsMessage()
		{
		}

		public GameActionFightExchangePositionsMessage(uint actionId, double sourceId, double targetId, short casterCellId, short targetCellId) : base(actionId, sourceId)
		{
			this.targetId = targetId;
			this.casterCellId = casterCellId;
			this.targetCellId = targetCellId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.targetId = reader.ReadDouble();
			this.casterCellId = reader.ReadShort();
			this.targetCellId = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(this.targetId);
			writer.WriteShort(this.casterCellId);
			writer.WriteShort(this.targetCellId);
		}
	}
}