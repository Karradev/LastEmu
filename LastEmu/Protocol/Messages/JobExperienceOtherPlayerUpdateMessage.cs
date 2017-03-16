using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class JobExperienceOtherPlayerUpdateMessage : JobExperienceUpdateMessage
	{
		public const uint Id = 6599;

		public double playerId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6599;
			}
		}

		public JobExperienceOtherPlayerUpdateMessage()
		{
		}

		public JobExperienceOtherPlayerUpdateMessage(JobExperience experiencesUpdate, double playerId) : base(experiencesUpdate)
		{
			this.playerId = playerId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.playerId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(this.playerId);
		}
	}
}