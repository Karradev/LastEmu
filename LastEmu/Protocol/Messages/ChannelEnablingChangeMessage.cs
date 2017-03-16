using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ChannelEnablingChangeMessage : NetworkMessage
	{
		public const uint Id = 891;

		public sbyte channel;

		public bool enable;

		public override uint ProtocolId
		{
			get
			{
				return (uint)891;
			}
		}

		public ChannelEnablingChangeMessage()
		{
		}

		public ChannelEnablingChangeMessage(sbyte channel, bool enable)
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