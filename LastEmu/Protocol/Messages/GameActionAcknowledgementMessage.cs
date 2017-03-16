using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GameActionAcknowledgementMessage : NetworkMessage
	{
		public const uint Id = 957;

		public bool valid;

		public sbyte actionId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)957;
			}
		}

		public GameActionAcknowledgementMessage()
		{
		}

		public GameActionAcknowledgementMessage(bool valid, sbyte actionId)
		{
			this.valid = valid;
			this.actionId = actionId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.valid = reader.ReadBoolean();
			this.actionId = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.valid);
			writer.WriteSByte(this.actionId);
		}
	}
}