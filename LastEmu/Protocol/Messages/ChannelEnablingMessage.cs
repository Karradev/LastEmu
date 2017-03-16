using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ChannelEnablingMessage : NetworkMessage
	{
		public const uint Id = 890;

		public sbyte channel;

		public bool enable;

		public override uint ProtocolId
		{
			get
			{
				return (uint)890;
			}
		}

		public ChannelEnablingMessage()
		{
		}

		public ChannelEnablingMessage(sbyte channel, bool enable)
		{
			this.channel = channel;
			this.enable = enable;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.channel = reader.ReadSByte();
			this.enable = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.channel);
			writer.WriteBoolean(this.enable);
		}
	}
}