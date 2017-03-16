using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightPointsVariationMessage : AbstractGameActionMessage
	{
		public const uint Id = 1030;

		public double targetId;

		public short delta;

		public override uint ProtocolId
		{
			get
			{
				return (uint)1030;
			}
		}

		public GameActionFightPointsVariationMessage()
		{
		}

		public GameActionFightPointsVariationMessage(uint actionId, double sourceId, double targetId, short delta) : base(actionId, sourceId)
		{
			this.targetId = targetId;
			this.delta = delta;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.targetId = reader.ReadDouble();
			this.delta = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(this.targetId);
			writer.WriteShort(this.delta);
		}
	}
}