using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ProtocolRequired : NetworkMessage
	{
		public const uint Id = 1;

		public int requiredVersion;

		public int currentVersion;

		public override uint ProtocolId
		{
			get
			{
				return (uint)1;
			}
		}

		public ProtocolRequired()
		{
		}

		public ProtocolRequired(int requiredVersion, int currentVersion)
		{
			this.requiredVersion = requiredVersion;
			this.currentVersion = currentVersion;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.requiredVersion = reader.ReadInt();
			this.currentVersion = reader.ReadInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.requiredVersion);
			writer.WriteInt(this.currentVersion);
		}
	}
}