using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class CharacterSelectionWithRemodelMessage : CharacterSelectionMessage
	{
		public const uint Id = 6549;

		public RemodelingInformation remodel;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6549;
			}
		}

		public CharacterSelectionWithRemodelMessage()
		{
		}

		public CharacterSelectionWithRemodelMessage(double id, RemodelingInformation remodel) : base(id)
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