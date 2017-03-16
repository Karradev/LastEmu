using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightModifyEffectsDurationMessage : AbstractGameActionMessage
	{
		public const uint Id = 6304;

		public double targetId;

		public short delta;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6304;
			}
		}

		public GameActionFightModifyEffectsDurationMessage()
		{
		}

		public GameActionFightModifyEffectsDurationMessage(uint actionId, double sourceId, double targetId, short delta) : base(actionId, sourceId)
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