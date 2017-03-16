using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ServerExperienceModificatorMessage : NetworkMessage
	{
		public const uint Id = 6237;

		public uint experiencePercent;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6237;
			}
		}

		public ServerExperienceModificatorMessage()
		{
		}

		public ServerExperienceModificatorMessage(uint experiencePercent)
		{
			this.experiencePercent = experiencePercent;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.experiencePercent = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.experiencePercent);
		}
	}
}