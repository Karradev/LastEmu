using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class CharacterReplayWithRemodelRequestMessage : CharacterReplayRequestMessage
	{
		public const uint Id = 6551;

		public RemodelingInformation remodel;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6551;
			}
		}

		public CharacterReplayWithRemodelRequestMessage()
		{
		}

		public CharacterReplayWithRemodelRequestMessage(double characterId, RemodelingInformation remodel) : base(characterId)
		{
			this.remodel = remodel;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.remodel = new RemodelingInformation();
			this.remodel.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.remodel.Serialize(writer);
		}
	}
}