using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightReflectSpellMessage : AbstractGameActionMessage
	{
		public const uint Id = 5531;

		public double targetId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5531;
			}
		}

		public GameActionFightReflectSpellMessage()
		{
		}

		public GameActionFightReflectSpellMessage(uint actionId, double sourceId, double targetId) : base(actionId, sourceId)
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