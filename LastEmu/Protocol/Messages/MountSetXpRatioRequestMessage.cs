using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MountSetXpRatioRequestMessage : NetworkMessage
	{
		public const uint Id = 5989;

		public sbyte xpRatio;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5989;
			}
		}

		public MountSetXpRatioRequestMessage()
		{
		}

		public MountSetXpRatioRequestMessage(sbyte xpRatio)
		{
			this.xpRatio = xpRatio;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.xpRatio = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.xpRatio);
		}
	}
}