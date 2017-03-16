using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class SetEnablePVPRequestMessage : NetworkMessage
	{
		public const uint Id = 1810;

		public bool enable;

		public override uint ProtocolId
		{
			get
			{
				return (uint)1810;
			}
		}

		public SetEnablePVPRequestMessage()
		{
		}

		public SetEnablePVPRequestMessage(bool enable)
		{
			this.enable = enable;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.enable = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.enable);
		}
	}
}