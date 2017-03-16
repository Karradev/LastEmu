using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ChangeThemeRequestMessage : NetworkMessage
	{
		public const uint Id = 6639;

		public sbyte theme;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6639;
			}
		}

		public ChangeThemeRequestMessage()
		{
		}

		public ChangeThemeRequestMessage(sbyte theme)
		{
			this.theme = theme;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.theme = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.theme);
		}
	}
}