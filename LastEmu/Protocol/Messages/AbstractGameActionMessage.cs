using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AbstractGameActionMessage : NetworkMessage
	{
		public const uint Id = 1000;

		public uint actionId;

		public double sourceId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)1000;
			}
		}

		public AbstractGameActionMessage()
		{
		}

		public AbstractGameActionMessage(uint actionId, double sourceId)
		{
			this.actionId = actionId;
			this.sourceId = sourceId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.actionId = reader.ReadVarUhShort();
			this.sourceId = reader.ReadDouble();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((short) this.actionId);
			writer.WriteDouble(this.sourceId);
		}
	}
}