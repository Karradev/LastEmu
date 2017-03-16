using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class MountHarnessColorsUpdateRequestMessage : NetworkMessage
	{
		public const uint Id = 6697;

		public bool useHarnessColors;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6697;
			}
		}

		public MountHarnessColorsUpdateRequestMessage()
		{
		}

		public MountHarnessColorsUpdateRequestMessage(bool useHarnessColors)
		{
			this.useHarnessColors = useHarnessColors;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.useHarnessColors = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.useHarnessColors);
		}
	}
}