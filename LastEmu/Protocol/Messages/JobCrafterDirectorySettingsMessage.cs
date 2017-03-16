using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class JobCrafterDirectorySettingsMessage : NetworkMessage
	{
		public const uint Id = 5652;

		public JobCrafterDirectorySettings[] craftersSettings;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5652;
			}
		}

		public JobCrafterDirectorySettingsMessage()
		{
		}

		public JobCrafterDirectorySettingsMessage(JobCrafterDirectorySettings[] craftersSettings)
		{
			this.craftersSettings = craftersSettings;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.craftersSettings = new JobCrafterDirectorySettings[num];
			for (int i = 0; i < num; i++)
			{
				this.craftersSettings[i] = new JobCrafterDirectorySettings();
				this.craftersSettings[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.craftersSettings.Length));
			JobCrafterDirectorySettings[] jobCrafterDirectorySettingsArray = this.craftersSettings;
			for (int i = 0; i < (int)jobCrafterDirectorySettingsArray.Length; i++)
			{
				jobCrafterDirectorySettingsArray[i].Serialize(writer);
			}
		}
	}
}