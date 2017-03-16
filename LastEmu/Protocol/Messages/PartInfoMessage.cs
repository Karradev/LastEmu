using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class PartInfoMessage : NetworkMessage
	{
		public const uint Id = 1508;

		public ContentPart part;

		public double installationPercent;

		public override uint ProtocolId
		{
			get
			{
				return (uint)1508;
			}
		}

		public PartInfoMessage()
		{
		}

		public PartInfoMessage(ContentPart part, double installationPercent)
		{
			this.part = part;
			this.installationPercent = installationPercent;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.part = new ContentPart();
			this.part.Deserialize(reader);
			this.installationPercent = (double)reader.ReadFloat();
		}

		public override void Serialize(IDataWriter writer)
		{
			this.part.Serialize(writer);
			writer.WriteFloat((float)this.installationPercent);
		}
	}
}