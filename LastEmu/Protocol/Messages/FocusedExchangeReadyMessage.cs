using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class FocusedExchangeReadyMessage : ExchangeReadyMessage
	{
		public const uint Id = 6701;

		public uint focusActionId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6701;
			}
		}

		public FocusedExchangeReadyMessage()
		{
		}

		public FocusedExchangeReadyMessage(bool ready, uint step, uint focusActionId) : base(ready, step)
		{
			this.focusActionId = focusActionId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.focusActionId = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarInt((int)this.focusActionId);
		}
	}
}