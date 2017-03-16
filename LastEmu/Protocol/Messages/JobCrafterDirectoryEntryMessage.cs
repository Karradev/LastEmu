using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class JobCrafterDirectoryEntryMessage : NetworkMessage
	{
		public const uint Id = 6044;

		public JobCrafterDirectoryEntryPlayerInfo playerInfo;

		public JobCrafterDirectoryEntryJobInfo[] jobInfoList;

		public EntityLook playerLook;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6044;
			}
		}

		public JobCrafterDirectoryEntryMessage()
		{
		}

		public JobCrafterDirectoryEntryMessage(JobCrafterDirectoryEntryPlayerInfo playerInfo, JobCrafterDirectoryEntryJobInfo[] jobInfoList, EntityLook playerLook)
		{
			this.playerInfo = playerInfo;
			this.jobInfoList = jobInfoList;
			this.playerLook = playerLook;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.playerInfo = new JobCrafterDirectoryEntryPlayerInfo();
			this.playerInfo.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.jobInfoList = new JobCrafterDirectoryEntryJobInfo[num];
			for (int i = 0; i < num; i++)
			{
				this.jobInfoList[i] = new JobCrafterDirectoryEntryJobInfo();
				this.jobInfoList[i].Deserialize(reader);
			}
			this.playerLook = new EntityLook();
			this.playerLook.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.playerInfo.Serialize(writer);
			writer.WriteShort((short)((int)this.jobInfoList.Length));
			JobCrafterDirectoryEntryJobInfo[] jobCrafterDirectoryEntryJobInfoArray = this.jobInfoList;
			for (int i = 0; i < (int)jobCrafterDirectoryEntryJobInfoArray.Length; i++)
			{
				jobCrafterDirectoryEntryJobInfoArray[i].Serialize(writer);
			}
			this.playerLook.Serialize(writer);
		}
	}
}