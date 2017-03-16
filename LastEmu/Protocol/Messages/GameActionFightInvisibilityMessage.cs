using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class GameActionFightInvisibilityMessage : AbstractGameActionMessage
	{
		public const uint Id = 5821;

		public double targetId;

		public sbyte state;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5821;
			}
		}

		public GameActionFightInvisibilityMessage()
		{
		}

		public GameActionFightInvisibilityMessage(uint actionId, double sourceId, double targetId, sbyte state) : base(actionId, sourceId)
		{
			this.targetId = targetId;
			this.state = state;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.targetId = reader.ReadDouble();
			this.state = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteDouble(this.targetId);
			writer.WriteSByte(this.state);
		}
	}
}