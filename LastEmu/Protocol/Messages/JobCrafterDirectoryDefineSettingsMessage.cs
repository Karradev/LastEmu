using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class JobCrafterDirectoryDefineSettingsMessage : NetworkMessage
	{
		public const uint Id = 5649;

		public JobCrafterDirectorySettings settings;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5649;
			}
		}

		public JobCrafterDirectoryDefineSettingsMessage()
		{
		}

		public JobCrafterDirectoryDefineSettingsMessage(JobCrafterDirectorySettings settings)
		{
			this.settings = settings;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.settings = new JobCrafterDirectorySettings();
			this.settings.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.settings.Serialize(writer);
		}
	}
}