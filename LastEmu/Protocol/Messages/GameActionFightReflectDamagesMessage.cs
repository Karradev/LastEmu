using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightReflectDamagesMessage : AbstractGameActionMessage
	{
		public const uint Id = 5530;

		public double targetId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5530;
			}
		}

		public GameActionFightReflectDamagesMessage()
		{
		}

		public GameActionFightReflectDamagesMessage(uint actionId, double sourceId, double targetId) : base(actionId, sourceId)
		{
			this.targetId = targetId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.targetId = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(this.targetId);
		}
	}
}