using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class IdolPartyRegisterRequestMessage : NetworkMessage
	{
		public const uint Id = 6582;

		public bool register;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6582;
			}
		}

		public IdolPartyRegisterRequestMessage()
		{
		}

		public IdolPartyRegisterRequestMessage(bool register)
		{
			this.register = register;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.register = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.register);
		}
	}
}