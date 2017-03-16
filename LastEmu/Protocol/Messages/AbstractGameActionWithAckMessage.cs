using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class AbstractGameActionWithAckMessage : AbstractGameActionMessage
	{
		public const uint Id = 1001;

		public short waitAckId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)1001;
			}
		}

		public AbstractGameActionWithAckMessage()
		{
		}

		public AbstractGameActionWithAckMessage(uint actionId, double sourceId, short waitAckId) : base(actionId, sourceId)
		{
			this.waitAckId = waitAckId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.waitAckId = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort(this.waitAckId);
		}
	}
}