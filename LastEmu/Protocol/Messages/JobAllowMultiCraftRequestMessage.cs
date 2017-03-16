using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class JobAllowMultiCraftRequestMessage : NetworkMessage
	{
		public const uint Id = 5748;

		public bool enabled;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5748;
			}
		}

		public JobAllowMultiCraftRequestMessage()
		{
		}

		public JobAllowMultiCraftRequestMessage(bool enabled)
		{
			this.enabled = enabled;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.enabled = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.enabled);
		}
	}
}